# Социальная сеть для обмена короткими заметками (напободие "Twitter")
Социальная сеть для обмена короткими заметками (ASP.NET MVC)

- Пользователи: 
   
	 __Гость__:		Неавторизованный пользователь сети. Все пользователи по умолчанию являются гостями.
 
   __Пользователь__:	Авторизованный пользователь. Все авторизованные пользователи и их логины/пароли добавляются на сервере вручную разработчиком, у пользователей сети нет возможностей их изменить.

- Страницы социальной сети

    	Главная / Лента постов (Index)

    	Форма авторизации (Register, Login)

    	Форма добавления/редактирования поста (AddPost, EditPost)

  Все экраны содержат следующие элементы:

      Кнопка авторизации / Имя пользователя / Кнопка выхода

      Кнопка Добавить пост

      Футер

  Кнопка _авторизации / Имя пользователя / Кнопка выхода_ имеет следующий вид:

      Для неавторизованного пользователя отображается кнопка авторизации. После нажатия на кнопку пользователь переходит на Экран «Форма авторизации»

      Для авторизованного пользователя отображается имя пользователя и кнопка выхода. После нажатия на кнопку пользователь становится неавторизованным и переходит на Экран «Главный / Лента постов».

  Кнопка _Добавить пост_ отображается для авторизованного пользователя. После нажатия на кнопку пользователь переходит на Экран «Форма добавления/редактирования поста»

  - __Страница «Главная / Лента постов»__

  Содержит следующие элементы:

      Лента постов

  Все посты в ленте упорядочены по дате добавления. Последние добавленные - вверху ленты. Каждый пост из списка отображает:

      -	Фотографию (если есть)
      -	Имя автора
      -	Дату добавления
      -	Краткое описание
      -	Список хештегов

  Для авторизованных пользователей также отображаются:

      -	Кнопка редактирования поста
      -	Кнопка удаления поста


  Авторизованный пользователь может редактировать СВОИ посты. После нажатия на кнопку редактирования поста пользователь переходит на страницу «Форма редактирования поста». Так же авторизованный пользователь может удалить свой пост.

  - __Страница «Форма авторизации»__

  Экран содержит следующие элементы:

      Форма авторизации

   Форма авторизации содержит следующие поля формы:

        -	Логин	(обязательное)	
        -	Пароль	(обязательное)

  Экран доступен только неавторизованным пользователям. После авторизации пользователь переходит на Экран «Главный / Лента постов».


  - __Страница «Форма добавления/редактирования поста»__

  Экран содержит следующие элементы:

    	Форма добавления/редактирования поста

  Форма добавления/редактирования поста содержит следующие поля формы:

      -	Кнопка для загрузки фото(ссылки на фото)(необязательное)
      -	Имя автора(нередактируемое): Имя автора - это логин пользователя
      -	Список тегов
      -	Дата добавления(нередактируемое): Текущая дата на момент добавления поста. Добавляется при создании поста автоматически
      -	Краткое описание(обязательное): Краткое описание поста для Ленты постов


  Экран доступен только авторизованным пользователям. После добавления поста пользователь переходит на Экран «Главный / Лента постов».

- __Страница «Связаться»__

  Экран содержит следующие элементы:

    	Форма отправки сообщения/письма в поддержку

  Форма отправки сообщения содержит следующие поля формы:

      -	Имя отправителя
      - 	Email отправителя: Чтобы была возможность связаться с ним и ответить
      - 	Тема сообщения (Subject)
      -	Текст письма

  Экран доступен всем пользователям. При успешной отправке сообщения появляется уведомление об этом на странице отправки.

