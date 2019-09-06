public static class LanguageStrings {
    public delegate string stringsMethods();

    public static stringsMethods[] strings = {
        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "I Have An Account";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Eu Tenho Uma Conta";
                case Configurations.Options.languages.SPANISH:
                    return "Tengo Una Cuenta";
                default:
                    return "I Have An Account";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "I Don't Have An Account";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Eu Não Tenho Uma Conta";
                case Configurations.Options.languages.SPANISH:
                    return "No Tengo Una Cuenta";
                default:
                    return "I Don't Have An Account";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "This game needs Location and Camera permission!";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Este jogo necessita das permissões de Localização e Câmera!";
                case Configurations.Options.languages.SPANISH:
                    return "Este juego necesita el permiso de Localización e Cámara!";
                default:
                    return "This game needs Location and Camera permission!";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Ok, ask again";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Ok, pergunte de novo";
                case Configurations.Options.languages.SPANISH:
                    return "Ok, pregunta otra vez";
                default:
                    return "Ok, ask again";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "No, close the game";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Não, fechar o jogo";
                case Configurations.Options.languages.SPANISH:
                    return "No, cierra el juego";
                default:
                    return "No, close the game";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "It seems that you doesn't have Internet access!";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Parece que você não possui acesso à Internet!";
                case Configurations.Options.languages.SPANISH:
                    return "Parece que no tienes acceso a internet!";
                default:
                    return "It seems that you doesn't have Internet access!";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Retry to connect";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Tentar conectar";
                case Configurations.Options.languages.SPANISH:
                    return "Intentar conectar";
                default:
                    return "Retry to connect";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Options";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Opções";
                case Configurations.Options.languages.SPANISH:
                    return "Opciones";
                default:
                    return "Options";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Sound:";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Som:";
                case Configurations.Options.languages.SPANISH:
                    return "Sonido:";
                default:
                    return "Sound:";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Music";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Música";
                case Configurations.Options.languages.SPANISH:
                    return "Música";
                default:
                    return "Music";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Effects";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Efeitos";
                case Configurations.Options.languages.SPANISH:
                    return "Efectos";
                default:
                    return "Effects";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Language:";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Idioma:";
                case Configurations.Options.languages.SPANISH:
                    return "Idioma:";
                default:
                    return "Language:";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Quit";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Sair";
                case Configurations.Options.languages.SPANISH:
                    return "Salir";
                default:
                    return "Quit";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Click here to open the Options Menu";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Clique aqui para abrir o Menu de Opções";
                case Configurations.Options.languages.SPANISH:
                    return "Clic aquí para abrir el Menú de Opciones";
                default:
                    return "Click here to open the Options Menu";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Do you have an Outside4Fun account?";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Você possui uma conta Outside4Fun?";
                case Configurations.Options.languages.SPANISH:
                    return "¿Tiene una cuenta de Outside4Fun?";
                default:
                    return "Do you have an Outside4Fun account?";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Yes";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Sim";
                case Configurations.Options.languages.SPANISH:
                    return "Sí";
                default:
                    return "Yes";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "No";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Não";
                case Configurations.Options.languages.SPANISH:
                    return "No";
                default:
                    return "No";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Then, click here";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Então, clique aqui";
                case Configurations.Options.languages.SPANISH:
                    return "Entonces, clic aquí";
                default:
                    return "Then, click here";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Skip";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Pular";
                case Configurations.Options.languages.SPANISH:
                    return "Saltar";
                default:
                    return "Skip";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Next";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Próximo";
                case Configurations.Options.languages.SPANISH:
                    return "Siguiente";
                default:
                    return "Next";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Select";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Selecionar";
                case Configurations.Options.languages.SPANISH:
                    return "Seleccionar";
                default:
                    return "Select";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Username";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Nome de usuário";
                case Configurations.Options.languages.SPANISH:
                    return "Nombre de usuario";
                default:
                    return "Username";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Password";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Senha";
                case Configurations.Options.languages.SPANISH:
                    return "Contraseña";
                default:
                    return "Password";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Login";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Entrar";
                case Configurations.Options.languages.SPANISH:
                    return "Entrar";
                default:
                    return "Login";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Select your style:";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Selecione o seu estilo:";
                case Configurations.Options.languages.SPANISH:
                    return "Seleccione su estilo:";
                default:
                    return "Select your style:";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Age";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Idade";
                case Configurations.Options.languages.SPANISH:
                    return "Edad";
                default:
                    return "Age";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Register";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Registrar";
                case Configurations.Options.languages.SPANISH:
                    return "Registro";
                default:
                    return "Register";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "This is the point of interest that we are looking for";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Este é o ponto de interesse que estamos procurando";
                case Configurations.Options.languages.SPANISH:
                    return "Este es el punto de interés que estamos buscando";
                default:
                    return "This is the point of interest that we are looking for";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "You must walk 30 meters in total to win 1 Euro, shown here";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Você deve andar 30 metros no total para ganhar 1 Euro, mostrado aqui";
                case Configurations.Options.languages.SPANISH:
                    return "Tú debes caminar 30 metros en total para ganar 1 Euro, mostrado aquí";
                default:
                    return "You must walk 30 meters in total to win 1 Euro, shown here";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Here shows the total Euros that you have";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Aqui mostra o total de Euros que você possui";
                case Configurations.Options.languages.SPANISH:
                    return "Aquí muestra el total de Euros que tú tienes";
                default:
                    return "Here shows the total Euros that you have";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "In the Menu you can see some informations about your account";
                case Configurations.Options.languages.PORTUGUESE:
                    return "No Menu você pode visualizar algumas informações sobre sua conta";
                case Configurations.Options.languages.SPANISH:
                    return "En el menú puedes ver alguna información sobre su cuenta";
                default:
                    return "In the Menu you can see some informations about your account";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "And in the bag are all items purchased";
                case Configurations.Options.languages.PORTUGUESE:
                    return "E na mochila estão todos os itens comprados";
                case Configurations.Options.languages.SPANISH:
                    return "Y en la mochila están todos los artículos comprados";
                default:
                    return "And in the bag are all items purchased";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "This is you. You need to walk, gain Euros and search for points of interest to expend your money!";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Este é você. Você precisa andar, ganhar Euros e procurar pontos de interesse para gastar seu dinheiro!";
                case Configurations.Options.languages.SPANISH:
                    return "Este eres tú. Tú necesita caminar, ganar Euros y buscar puntos de interés para gastar su dinero!";
                default:
                    return "This is you. You need to walk, gain Euros and search for points of interest to expend your money!";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Let's Play!";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Vamos Jogar!";
                case Configurations.Options.languages.SPANISH:
                    return "¡Vamos a jugar!";
                default:
                    return "Let's Play!";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Logout";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Sair da conta";
                case Configurations.Options.languages.SPANISH:
                    return "Salir de la cuenta";
                default:
                    return "Logout";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Menu";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Menu";
                case Configurations.Options.languages.SPANISH:
                    return "Menú";
                default:
                    return "Menu";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "My Bag";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Minha Mochila";
                case Configurations.Options.languages.SPANISH:
                    return "Mi Mochila";
                default:
                    return "My Bag";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Daily Missions (in development)";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Missões Diárias (em desenvolvimento)";
                case Configurations.Options.languages.SPANISH:
                    return "Misiones Diarias (en desarrollo)";
                default:
                    return "Daily Missions (in development)";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Buy 5 Bananas Reward: 5 EUR";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Compre 5 Bananas Recompensa: 5 EUR";
                case Configurations.Options.languages.SPANISH:
                    return "Compra 5 Bananas Recompensa: 5 EUR";
                default:
                    return "Buy 5 Bananas Reward: 5 EUR";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Buy 2 Muffins Reward: 1 EUR";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Compre 2 Muffins Recompensa: 1 EUR";
                case Configurations.Options.languages.SPANISH:
                    return "Compra 2 Muffins Recompensa: 1 EUR";
                default:
                    return "Buy 2 Muffins Reward: 1 EUR";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Congratulations! You finished the tutorial.";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Parabéns! Você terminou o tutorial.";
                case Configurations.Options.languages.SPANISH:
                    return "Felicitaciones! Terminastes el tutorial.";
                default:
                    return "Congratulations! You finished the tutorial.";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Buy 10 Wines Reward: 10 EUR";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Compre 10 Vinhos Recompensa: 10 EUR";
                case Configurations.Options.languages.SPANISH:
                    return "Compra 10 Vinos Recompensa: 10 EUR";
                default:
                    return "Buy 10 Wines Reward: 10 EUR";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Enter";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Entrar";
                case Configurations.Options.languages.SPANISH:
                    return "Entrar";
                default:
                    return "Enter";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "too far.";
                case Configurations.Options.languages.PORTUGUESE:
                    return "muito distante.";
                case Configurations.Options.languages.SPANISH:
                    return "muy distante.";
                default:
                    return "too far.";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Buy";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Comprar";
                case Configurations.Options.languages.SPANISH:
                    return "Comprar";
                default:
                    return "Buy";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Return to map";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Retornar ao mapa";
                case Configurations.Options.languages.SPANISH:
                    return "Volver al mapa";
                default:
                    return "Return to map";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Select an item to buy.";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Selecione um item para comprar.";
                case Configurations.Options.languages.SPANISH:
                    return "Seleccione un artículo para comprar.";
                default:
                    return "Select an item to buy.";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Welcome to";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Bem-vindo ao";
                case Configurations.Options.languages.SPANISH:
                    return "Bienvenido a";
                default:
                    return "Welcome to";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Do you want to SKIP or START the tutorial?";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Você quer PULAR ou INICIAR o tutorial?";
                case Configurations.Options.languages.SPANISH:
                    return "Quieres SALTAR o INICIAR el tutorial?";
                default:
                    return "Do you want to SKIP or START the tutorial?";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Start";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Iniciar";
                case Configurations.Options.languages.SPANISH:
                    return "Iniciar";
                default:
                    return "Start";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Are you sure you want to quit?";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Você tem certeza que deseja sair?";
                case Configurations.Options.languages.SPANISH:
                    return "Estás seguro de que quieres salir?";
                default:
                    return "Are you sure you want to quit?";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Select a tour to begin the game:";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Selecione um tour para começar o jogo:";
                case Configurations.Options.languages.SPANISH:
                    return "Seleccione un tour para comenzar el juego:";
                default:
                    return "Select a tour to begin the game:";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "University of Deusto Tour";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Tour da Universidade de Deusto";
                case Configurations.Options.languages.SPANISH:
                    return "Tour en la Universidad de Deusto";
                default:
                    return "University of Deusto Tour";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "The first point you should enter is in the engineering building of the University of Deusto.";
                case Configurations.Options.languages.PORTUGUESE:
                    return "O primeiro ponto que você deve entrar é no prédio de engenharia da Universidade de Deusto.";
                case Configurations.Options.languages.SPANISH:
                    return "El primer punto al que debe ingresar es en el edificio de ingeniería de la Universidad de Deusto.";
                default:
                    return "The first point you should enter is in the engineering building of the University of Deusto.";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Now you should go to the cafeteria of the engineering building.";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Agora você deverá ir para a cafetería do prédio de engenharia.";
                case Configurations.Options.languages.SPANISH:
                    return "Ahora deberías ir a la cafetería del edificio de ingeniería.";
                default:
                    return "Now you should go to the cafeteria of the engineering building.";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "For now, we will go to the joint between two buildings.";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Por enquanto, vamos para a junção entre dois prédios.";
                case Configurations.Options.languages.SPANISH:
                    return "Por ahora, iremos a la articulación entre dos edificios.";
                default:
                    return "For now, we will go to the joint between two buildings.";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Theres a church in the next building, let's go.";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Há uma igreja no prédio ao lado, vamos lá.";
                case Configurations.Options.languages.SPANISH:
                    return "Hay una iglesia en el próximo edificio, vamos.";
                default:
                    return "Theres a church in the next building, let's go.";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "And to complete this building, let's enter in the library.";
                case Configurations.Options.languages.PORTUGUESE:
                    return "E para completar este edifício, vamos entrar na biblioteca.";
                case Configurations.Options.languages.SPANISH:
                    return "Y para completar este edificio, entremos en la biblioteca.";
                default:
                    return "And to complete this building, let's enter in the library.";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "To finish, there is a big library out of the university. You can see it in the map, by rotating and zooming the screen.";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Para terminar, há uma grande biblioteca fora da universidade. Você pode vê-lo no mapa, girando e ampliando a tela.";
                case Configurations.Options.languages.SPANISH:
                    return "Para terminar, hay una gran biblioteca fuera de la universidad. Puedes verlo en el mapa, girando y acercando la pantalla.";
                default:
                    return "To finish, there is a big library out of the university. You can see it in the map, by rotating and zooming the screen.";
            }
        },

        () => {
            switch(Configurations.Options.language) {
                case Configurations.Options.languages.ENGLISH:
                    return "Congratulations! You finished the Deusto University Tour.";
                case Configurations.Options.languages.PORTUGUESE:
                    return "Parabéns! Você terminou o Tour da Universidade de Deusto.";
                case Configurations.Options.languages.SPANISH:
                    return "Felicidades! Terminaste el Tour en la Universidad de Deusto.";
                default:
                    return "Congratulations! You finished the Deusto University Tour.";
            }
        }
    };

    public enum stringNames {
        I_Have_An_Account,
        I_Dont_Have_An_Account,
        This_game_needs_Location_and_Camera_permission,
        Ok_ask_again,
        No_close_the_game,
        It_seems_that_you_doesnt_have_Internet_access,
        Retry_to_connect,
        Options,
        Sound,
        Music,
        Effects,
        Language,
        Quit,
        Click_here_to_open_the_Options_Menu,
        Do_you_have_an_Outside4Fun_account,
        Yes,
        No,
        Then_click_here,
        Skip,
        Next,
        Select,
        Username,
        Password,
        Login,
        Select_your_style,
        Age,
        Register,
        This_is_the_point_of_interest_that_we_are_looking_for,
        You_must_walk_30_meters_in_total_to_win_1_Euro_shown_here,
        Here_shows_the_total_Euros_that_you_have,
        In_the_Menu_you_can_see_some_informations_about_your_account,
        And_in_the_bag_are_all_items_purchased,
        This_is_you_You_need_to_walk_gain_Euros_and_search_for_points_of_interest_to_expend_your_money,
        Lets_Play,
        Logout,
        Menu,
        My_Bag,
        Daily_Missions_in_development,
        Buy_5_Bananas_Reward_5_EUR,
        Buy_2_Muffins_Reward_1_EUR,
        Congratulations_You_finished_the_tutorial,
        Buy_10_Wines_Reward_10_EUR,
        Enter,
        Too_far,
        Buy,
        Return_To_Map,
        Select_an_item_to_buy,
        Welcome_To,
        Do_you_want_to_SKIP_or_START_the_tutorial,
        Start,
        Are_you_sure_you_want_to_quit,
        Select_a_tour_to_begin_the_game,
        University_of_Deusto_Tour,
        University_of_Deusto_Tour_Engineering_Text,
        University_of_Deusto_Tour_Cafeteria_Text,
        University_of_Deusto_Tour_Joint_Text,
        University_of_Deusto_Tour_Church_Text,
        University_of_Deusto_Tour_SmallLibrary_Text,
        University_of_Deusto_Tour_Library_Text,
        University_of_Deusto_Tour_Finish_Text
    };
}
