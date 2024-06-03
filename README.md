# Возможности апи
Swagger не смог поместить в докер, почему то не дает доступ к Docker Hub. Запросы отправлял в Postman.
Swagger доступен по http://localhost:64589/swagger/index.html
1. Получить вопрос по id. Метод Get Пример: http://localhost:64589/api/question/get?questionId=1
2. Отправить ответ на вопрос. Метод Post. Пример: http://localhost:64589/api/result/save в теле отправить
{
  "interviewId": 1,
  "questionId": 1,
  "answerId": 2
}
