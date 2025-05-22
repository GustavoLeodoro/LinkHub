$(document).ready(function () {
    // Inicializa DataTables nas tabelas de contatos e usuários
    $('#table-contatos, #table-usuarios').DataTable({
        language: {
            url: "//cdn.datatables.net/plug-ins/1.13.6/i18n/pt-BR.json"
        }
    });

    // Fecha alertas ao clicar no botão de fechar
    $('.close-alert').click(function () {
        $('.alert').hide();
    });

    // Exibe contatos por usuário ao clicar no botão
    $('.btn-total-contatos').click(function () {
        var usuarioId = $(this).attr('usuario-id');

        $.ajax({
            type: 'GET',
            url: '/Usuario/ListarContatosPorUsuarioId/' + usuarioId,
            success: function (result) {
                $("#listaContatosUsuario").html(result);
                $('#modalContatosUsuario').modal('show');

                // Destroi DataTable se já existir
                if ($.fn.DataTable.isDataTable('#table-contatos-usuario')) {
                    $('#table-contatos-usuario').DataTable().destroy();
                }

                // Inicializa DataTable para contatos do usuário
                $('#table-contatos-usuario').DataTable({
                    language: {
                        url: "//cdn.datatables.net/plug-ins/1.13.6/i18n/pt-BR.json"
                    }
                });
            }
        });
    });
});

// Script para controle de tema com localStorage e data-bs-theme do Bootstrap
(() => {
    const getPreferredTheme = () => {
        const storedTheme = localStorage.getItem('theme');
        if (storedTheme) return storedTheme;

        return window.matchMedia('(prefers-color-scheme: dark)').matches ? 'dark' : 'light';
    };

    const setTheme = function (theme) {
        if (theme === 'auto') {
            document.documentElement.removeAttribute('data-bs-theme');
        } else {
            document.documentElement.setAttribute('data-bs-theme', theme);
        }
    };

    const updateThemeUI = (theme) => {
        document.querySelectorAll('[data-bs-theme-value]').forEach(el =>
            el.classList.remove('active')
        );
        const activeBtn = document.querySelector(`[data-bs-theme-value="${theme}"]`);
        if (activeBtn) activeBtn.classList.add('active');

        const icon = {
            light: 'bi-sun-fill',
            dark: 'bi-moon-stars-fill',
            auto: 'bi-circle-half'
        };

        const themeIcon = document.getElementById('theme-icon');
        const themeText = document.getElementById('theme-text');
        if (themeIcon) themeIcon.className = `bi ${icon[theme]} me-2`;
        if (themeText) themeText.textContent = theme.charAt(0).toUpperCase() + theme.slice(1);
    };

    // Aplica o tema preferido ao carregar
    const currentTheme = getPreferredTheme();
    setTheme(currentTheme);
    updateThemeUI(currentTheme);

    // Adiciona evento aos botões para trocar tema
    document.querySelectorAll('[data-bs-theme-value]').forEach(btn => {
        btn.addEventListener('click', () => {
            const theme = btn.getAttribute('data-bs-theme-value');
            localStorage.setItem('theme', theme);
            setTheme(theme);
            updateThemeUI(theme);
        });
    });
})();
