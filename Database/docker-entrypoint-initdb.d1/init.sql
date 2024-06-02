
-- Создание таблицы Survey
CREATE TABLE Survey (
    id SERIAL PRIMARY KEY,
    title VARCHAR(255) NOT NULL,
    description TEXT,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- Создание таблицы Question
CREATE TABLE Question (
    id SERIAL PRIMARY KEY,
    survey_id INT NOT NULL,
    text TEXT,
    type VARCHAR(50),
    nextquestionid integer,
    FOREIGN KEY (survey_id) REFERENCES Survey(id)
);

-- Создание таблицы Answer
CREATE TABLE Answer (
    id SERIAL PRIMARY KEY,
    question_id INT NOT NULL,
    text TEXT,
    FOREIGN KEY (question_id) REFERENCES Question(id)
);

-- Создание таблицы Interview
CREATE TABLE Interview (
    id SERIAL PRIMARY KEY,
    survey_id INT NOT NULL,
    participant_name VARCHAR(100),
    start_time TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    end_time TIMESTAMP,
    FOREIGN KEY (survey_id) REFERENCES Survey(id)
);

-- Создание таблицы Result
CREATE TABLE Result (
    id SERIAL PRIMARY KEY,
    interview_id INT NOT NULL,
    question_id INT NOT NULL,
    answer_id INT NOT NULL,
    FOREIGN KEY (interview_id) REFERENCES Interview(id),
    FOREIGN KEY (question_id) REFERENCES Question(id),
    FOREIGN KEY (answer_id) REFERENCES Answer(id)
);

-- Заполняем таблицу Survey тестовыми данными
INSERT INTO Survey (title, description) VALUES
('Опрос о любимой музыке', 'Опрос о предпочтениях в музыкальных жанрах'),
('Опрос о спорте', 'Опрос о предпочтениях в спорте');

-- Получаем последний survey_id
WITH max_survey_id AS (SELECT MAX(id) as max_id FROM Survey)
SELECT max_id INTO max_survey_id FROM max_survey_id;

-- Заполняем таблицу Question тестовыми данными
INSERT INTO Question (survey_id, text, type, nextquestionid) VALUES
((SELECT max_id FROM max_survey_id) - 1, 'Какой ваш любимый музыкальный жанр?', 'ответ выбором', 2),
((SELECT max_id FROM max_survey_id) - 1, 'Кто ваш любимый музыкальный исполнитель?', 'ответ выбором', null),
((SELECT max_id FROM max_survey_id), 'Какой вид спорта вам нравится больше всего?', 'ответ выбором', 4),
((SELECT max_id FROM max_survey_id), 'Какой спортивный клуб вам нравится?', 'ответ выбором', null);

-- Получаем последний question_id
WITH max_question_id AS (SELECT MAX(id) as max_id FROM Question)
SELECT max_id INTO max_question_id FROM max_question_id;

-- Заполняем таблицу Answer тестовыми данными
INSERT INTO Answer (question_id, text) VALUES
((SELECT max_id FROM max_question_id)-3, 'Поп'),
((SELECT max_id FROM max_question_id)-3, 'Рок'),
((SELECT max_id FROM max_question_id)-2, 'The Beatles'),
((SELECT max_id FROM max_question_id)-2, 'Queen'),
((SELECT max_id FROM max_question_id)-1, 'Футбол'),
((SELECT max_id FROM max_question_id)-1, 'Баскетбол'),
((SELECT max_id FROM max_question_id), 'Реал Мадрид'),
((SELECT max_id FROM max_question_id), 'Барселона');

INSERT INTO Interview (survey_id, participant_name) VALUES
(1, 'Test');