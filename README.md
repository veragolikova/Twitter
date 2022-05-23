# Social network for sharing short notes (like "Twitter")

Social network for sharing short notes (ASP.NET MVC)

# Description

- Users:
   
__Guest__: Unauthorized network user. All users are guests by default.
 
   __User__: Authorized user. All authorized users and their logins/passwords are added on the server manually by the developer; network users do not have the ability to change them.

- Social network pages

    Home / Post feed (Index)

    Authorization form (Register, Login)

    Form for adding/editing a post (AddPost, EditPost)

  All screens contain the following elements:

      Login button / Username / Logout button

      Add post button

      Footer

  The _authorization / Username / Exit button_ button look like this:

      For an unauthorized user, an authorization button is displayed. After clicking on the button, the user goes to the "Authorization Form" Page

      For an authorized user, the username and logout button are displayed. After clicking on the button, the user becomes unauthorized and goes to the "Home / Post Feed" Page.

  The _Add post_ button is displayed for the authorized user. After clicking on the button, the user goes to the “Add/Edit Post Form” Page

  - __Page "Main / Post feed"__

  Contains the following elements:

      Post feed

  All posts in the feed are sorted by the date they were added. Recently added - at the top of the feed. Each post from the list displays:

      - Photograph (if any)
      - Author's name
      - Date added
      - Short description
      - List of hashtags


  For authorized users, the following is also displayed:

      - Post edit button
      - Post delete button


  An authorized user can edit HIS posts. After clicking on the edit post button, the user goes to the "Edit Post Form" page. Also, an authorized user can delete his post.

  - __Authorization Form Page__

  The page contains the following elements:

      Authorization form

   The authorization form contains the following form fields:

        - Login (required)
        - Password (required)

  The page is only accessible to unauthorized users. After authorization, the user goes to the Main Page / Post Feed.


  - __Page "Add/Edit Post Form"__

  The page contains the following elements:

    	Form for adding/editing a post

  The form for adding/editing a post contains the following form fields:

      - Button to upload a photo (links to photos) (optional)
      - Author name (non-editable): Author name is the user's login
      - List of tags
      - Date added (non-editable): The current date at the time the post was added. Added when creating a post automatically
      - Short Description(required): Short description of the post for the Post Feed


  The page is available only to authorized users. After adding a post, the user goes to the "Home / Post Feed" Page.

- __Contact Page__

  The page contains the following elements:

    	Form for sending a message / letter to support

  The form for sending a message contains the following form fields:

      -	Sender's name
      - Email of the sender: To be able to contact him and reply
      - Message subject (Subject)
      -	Text of the letter

  The page is available to all users. When the message is successfully sent, a notification about it appears on the sending page.

# Examples of pages

__1. Main page where users can post their notes.__

![1](https://user-images.githubusercontent.com/70706111/169801829-a457a7f3-e305-44b4-9f9c-23fa827f7fc8.png)
![2](https://user-images.githubusercontent.com/70706111/169801831-f52c968e-9e64-49d9-8010-83dee6c72e7a.png)
![3](https://user-images.githubusercontent.com/70706111/169801833-a239ec86-2fc4-4144-b5ab-e907807e874d.png)

__2. Authorization and registration forms__

![4](https://user-images.githubusercontent.com/70706111/169801835-a4ded518-cfd4-4726-8ae4-a97737e5d04f.png)


![5](https://user-images.githubusercontent.com/70706111/169801836-2b200ac1-f321-476b-8338-30a4cd271645.png)
 
__3. Form of adding/editing a post__


![6](https://user-images.githubusercontent.com/70706111/169801841-7e3923af-4279-4234-aeeb-d412c935120d.png)
![7](https://user-images.githubusercontent.com/70706111/169801843-e20bb166-32e6-4ab3-bad0-d76c775ae346.png)


![8](https://user-images.githubusercontent.com/70706111/169801845-18301f9f-e961-42b7-814f-eed187c0b691.png)
![9](https://user-images.githubusercontent.com/70706111/169801851-e3c53557-df64-4c01-bc66-d9574c7e11ac.png)
      

__4. Error__

![10](https://user-images.githubusercontent.com/70706111/169801855-ec396267-e763-4f8b-9af1-ad6b0914af83.png)


_______________________________________________________________________________________________________________________________________________________________________


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

