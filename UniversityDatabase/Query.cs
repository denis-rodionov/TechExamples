using System;
using System.Collections.Generic;
using System.Text;

namespace University
{
  class Query
  {
    // вгоняет текст в кавычки если этот текст не "NULL"
    public static string setQuotes(string text)
    {
      return text == "NULL" ? "NULL" : "'" + text + "'";
    }

    // Выборка всех факультетов
    public static string selectAllFacs()
    {
      return "SELECT facID, facName AS 'Название', facDesc, " +
             " firstName, lastName, thirdName, headID " + 
             "FROM FacultiesView " +
             "ORDER BY 1";
    }

    // Выборка всех кафедр
    public static string selectAllCaths()
    {
      return "SELECT cathID, cathName AS 'Название', cathIndex AS 'Индекс', " +
             " cathDesc, facName, " +
             "  firstName, lastName, thirdName " +
             "FROM CathedrasView " +
             "ORDER BY 1";
    }

    // Выборка всех кафедр:  (<index>) <name>
    public static string selectAllCathsWithIndex()
    {
      return "SELECT cathID, '('+cathIndex+') ' + cathName " +
             "FROM cathedras " +
             "ORDER BY 1";
    }

    // выборка всех вреподавателей 
    public static string selectAllTeachers()
    {
      return "SELECT teachID, lastName AS 'Фамилия', firstName AS 'Иия', " + 
               "thirdName AS 'Отчество', degText AS 'Степень '" +
             "FROM TeachersView " +             
             "ORDER BY 1, 2";
    }

    // выборка преплдавателей по имени факультета
    public static string selectTeachsByFact(string facName)
    {
      return "SELECT teachID, lastName AS 'Фамилия', firstName AS 'Иия', " +
               "thirdName AS 'Отчество', d.degText AS 'Степень '" +
             "FROM Teachers t JOIN Cathedras c ON t.cathID = c.cathID " +
             "JOIN Faculties f ON c.facID = f.facID " +
             "JOIN DegreesTable d ON t.degree = d.degID " +
             "WHERE f.facName = '" + facName + "' ORDER BY 1, 2";
    }

    // выборка преподавателей, закреплённых за данной кафедрой
    public static string selectTeachsByCath(string cathName)
    {
      return "SELECT teachID, lastName AS 'Фамилия', firstName AS 'Иия', " +
               "thirdName AS 'Отчество', d.degText AS 'Степень' " +
             "FROM Teachers t JOIN Cathedras c ON t.cathID = c.cathID " +
             "JOIN DegreesTable d ON t.degree = d.degID "+
             "WHERE c.cathName = '" + cathName + "' ORDER BY 1, 2";
    }

    // выборка кафедр, принадлежащих заданному факультету
    public static string selectCathsByFac(string facName)
    {
      return "SELECT cathID, cathName AS 'Название', cathIndex AS 'Индекс', " +
             " cathDesc, facName, firstName, lastName, thirdName " +
             "FROM CathedrasView " +
             "WHERE facName = '" + facName + "' ORDER BY 2";
    }

    // выборка преподавателя по имени, фамилии и отчеству (полная информация)
    public static string selectTeach(string firstName, string lastName, string thirdName)
    {
      string thirdString = thirdName == "" || thirdName == null ? "" :
            "AND thirdName = '" + thirdName + "'";

      return "SELECT teachID, firstName, lastName, thirdName, pasNo, degText, " +
             " age, phone, address, cathName, postText, rankText " +
             "FROM TeachersView " +             
             "WHERE firstName = '" + firstName + "' " +
             "AND   lastName  = '" + lastName + "' " + thirdString;
    }

    // выборка преподавателя по ID
    public static string selectTeach(int id)
    {
      return "SELECT teachID, firstName, lastName, thirdName, pasNo, degText, " +
             " age, phone, address, cathName,  " +
             "lastName + ' ' + firstName + ' ' + thirdName AS Имя, " +
             "postText, rankText " +
             "FROM TeachersView " +
             "WHERE teachID = " + id.ToString();
    }

    // Выборка всех статусов преподавателей
    public static string selectAllDegs()
    {
      return "SELECT degID, degText " +
             "FROM DegreesTable ";
    }

    // обновление информации о преподавателе
    public static string updateTeach(int teachID, string firstName,
                                     string lastName, string thirdName,
                                     string age, string pasNO,
                                     string phone, string address,
                                     string degree, string cathName, 
                                     string post, string rank)
    {
      string cn = cathName == "NULL" ? "NULL" : "'" + cathName + "'";
      return "UPDATE TeachersView " +
             "SET firstName = '" + firstName + "', " +
             "lastName = '" + lastName + "', " +
             "thirdName = '" + thirdName + "', " +
             "pasNO = '" + pasNO + "', " +
             "age = " + (age == "" ? "NULL" : age) + ", " +
             "phone = " + (phone == "" ? "NULL" : phone) + ", " +
             "address = '" + address + "', " +
             "degText = '" + degree + "', " +
             "cathName = " + cn + ", " +             
             "postText = '" + post + "', " +
             "rankText = '" + rank + "' " + 
             "WHERE teachID = " + teachID.ToString();
    }

    // добавление преподавателя в таблицу
    public static string insertTeach(string firstName,
                                     string lastName, string thirdName,
                                     string age, string pasNO,
                                     string phone, string address,
                                     string degree, string cathName,
                                     string post, string rank)
    {
      string cn = cathName == "NULL" ? "NULL" : "'" + cathName + "'";
      return "INSERT INTO TeachersView " +
             "(teachID, firstName, lastName, thirdName, pasNO, age, " +
             " phone, address, degText, cathName, postText, rankText) " +
             "VALUES(0, '" + firstName + "', " +
             "'" + lastName + "', " +
             "'" + thirdName + "', " +
             "'" + pasNO + "', " +
             " " + (age == "" ? "NULL" : age) + ", " +
             " " + (phone == "" ? "NULL" : phone) + ", " +
             "'" + address + "', " +
             "'" + degree + "', " +
             " " + cn + ", " +
             " '" + post + "', " +
             " '" + rank + "')";
    }

    // количество преподавателей, принадлежащих данной кафедре
    public static string countOfTeachsOfCaths(int id)
    {
      return "SELECT COUNT(teachID) " +
             "FROM TeacherS " +
             "WHERE cathID = " + id.ToString();
    }

    // удаление кафедры
    public static string deleteCath(int cathID)
    {
      return "DELETE Cathedras " +
             "WHERE cathID = " + cathID.ToString();
    }

    // колличество преподавателей
    public static string countOfTeachs()
    {
      return "SELECT COUNT(teachID) " +
             "FROM Teachers";
    }

    // добавление кафедры
    public static string insertCath(string name, string index, string desc,
                                    int headID, int facID)
    {
      return "INSERT INTO Cathedras (cathName, cathIndex, cathDesc, " +
             "  headID, facID) " +
             "VALUES('" + name + "', '" + index + "', '" + desc +
             "', " + headID.ToString() + ", " + facID.ToString() + ")";             
    }

    // выбор кафедры по ID
    public static string selectCath(int cathID)
    {
      return "SELECT cathID, cathName, cathIndex, cathDesc, facName, " +
             " firstName, lastName, thirdName, teachID " +
             "FROM CathedrasView " +
             "WHERE cathID = " + cathID.ToString();
    }

    // обновление кафедры
    public static string updateCath(int cathID, string name, string index,
                                  string desc, int facID, int headID)
    {
      return "UPDATE Cathedras SET " +
             "cathName = '" + name + "', " +
             "cathIndex = '" + index + "', " +
             "cathDesc = '" + desc + "', " +
             "facID = " + facID.ToString() + ", " +
             "headID = " + headID.ToString() + " " +
             "WHERE cathID = " + cathID.ToString();
    }

    // добавление факультета
    public static string insertFac(string name, string desc, int headID)
    {
      return "INSERT INTO Faculties (facName, facDesc, headID) " +
             "VALUES ('" + name + "', '" + desc + "', " + headID.ToString() + ")";
    }

    // Изменение факультета
    public static string updateFac(int facID, string name, string desc, int headID)
    {
      return "UPDATE Faculties SET " +
             "facName = '" + name + "', " +
             "facDesc = '" + desc + "', " +
             "headID = " + headID.ToString() + " " +
             "WHERE facID = " + facID.ToString();
    }

    // выбор факультета по OD
    public static string selectFac(int facID)
    {
      return "SELECT facID, facName, facDesc, firstName, lastName, thirdName, headID " +
             "FROM FacultiesView " +
             "WHERE facID = " + facID.ToString();
    }

    // количество кафедр, принадлежащих определённому факультету
    public static string countOfCaths(int facID)
    {
      return "SELECT COUNT(cathID) " +
             "FROM Cathedras " +
             "WHERE facID = " + facID.ToString();
    }

    // удаление факультета
    public static string deleteFac(int facID)
    {
      return "DELETE Faculties " +
             "WHERE facID = " + facID.ToString();
    }

    // удаление преподавателя
    public static string deleteTeach(int teachID)
    {
      return "DELETE Teachers " +
             "WHERE teachID = " + teachID.ToString();
    }

    // Выборка всех групп
    public static string selectAllGroups()
    {
      return "SELECT groupID, groupIndex AS Индекс, " + 
             "  course AS Семестр, specName AS Специальность, firstName, " +
             "  lastName, thirdName, curatorID, cathName AS Кафедра," + 
             "  facName AS Факультет, studCount AS [Количество студентов] " +
             "FROM GroupsView";
    }

    // Выборка групп по конкретной специальности
    public static string selectGroupsBySpec(string specName)
    {
      return "SELECT groupID, groupIndex AS Индекс, " +
             "  course AS Семестр, specName AS Специальность, firstName, " +
             "  lastName, thirdName, curatorID, cathName AS Кафедра," +
             "  facName AS Факультет, studCount AS [Количество студентов] " +
             "FROM GroupsView " +
             "WHERE specName = '" + specName + "'";
    }

    // Выборка групп по конкретному факультету
    public static string selectGroupsByFac(string facName)
    {
      return "SELECT groupID, groupIndex AS Индекс, " +
             "  course AS Семестр, specName AS Специальность, firstName, " +
             "  lastName, thirdName, curatorID, cathName AS Кафедра," +
             "  facName AS Факультет, studCount AS [Количество студентов] " +
             "FROM GroupsView " +
             "WHERE facName = '" + facName + "'";
    }

    // Выборка всех специальностей
    public static string selectAllSpecs()
    {
      return "SELECT specID, specName, cathID " +
             "FROM Specialities ";
    }

    // добавление новой группы
    public static string insertGroup(string index, string curatorID,
                                     string specName, string course)
    {
      string specName1 = setQuotes(specName);
      string spec = specName1 == "NULL" ? "NULL" : "specID";

      return "INSERT INTO Groups (groupIndex, curatorID, specID, course) " +
             "SELECT '" + index + "', " + curatorID + ", "
                  + spec + ", " + course + " " +
             "FROM Specialities " +
             (specName1 != "NULL" ? "WHERE specName = " + specName1 : "");
    }

    // изменение группы
    public static string updateGroup(string groupID, string index, string curatorID,
                                     string specName, string course)
    {
      string specName1 = setQuotes(specName);
      string spec = specName1 == "NULL" ? "NULL" : "s.specID";

      return "UPDATE Groups SET " +
             "  groupIndex = '" + index + "', " +
             "  curatorID = " + curatorID + ", " +
             "  specID = " + spec + ", " +
             "  course = " + course + " " +
             "FROM Groups g, Specialities s " +
             "WHERE g.groupID = " + groupID + " " +
             (specName1 != "NULL" ? "AND s.specName = " + specName1 : ""); 
    }

    // удаление группы
    public static string deleteGroup(int groupID)
    {
      return "DELETE Groups " +
             "WHERE groupID = " + groupID.ToString();
    }

    // выборка всех студентов
    public static string selectAllStudents()
    {
      return "SELECT studID, firstName AS Имя, lastName AS Фамилия, " +
             "  thirdName As Отчество, pasNO AS Паспорт, " +
             "  recordBook, age, startYear, phone AS Телефон, address AS Адрес, groupID, " +
             "  course AS Семестр, groupIndex AS Группа, cathName " + 
             "  AS Кафедра, facName AS Факультет " +
             "FROM StudentsView " +
             "ORDER BY 3 "; 
    }

    // выборка студентов по группе
    public static string selectStudsByGroup(string groupIndex)
    {
      return "SELECT studID, firstName AS Имя, lastName AS Фамилия, " +
             "  thirdName As Отчество, pasNO AS Паспорт, " +
             "  recordBook, age, startYear, phone AS Телефон, address AS Адрес, groupID, " +
             "  course AS Семестр, groupIndex AS Группа, cathName " +
             "  AS Кафедра, facName AS Факультет " +
             "FROM StudentsView " +
             "WHERE groupIndex = '" + groupIndex + "' " +
             "ORDER BY 3 ";
    }

    // выборка расписания
    public static string selectTimetable()
    {
        return "SELECT id, s.subName, t.lastName, g.groupIndex, day_of_week, pair_number " +
               "FROM Timetable tt INNER JOIN Subjects s ON tt.subID = s.subID " +
               "INNER JOIN Groups g ON tt.groupID = g.groupID " +
               "INNER JOIN Teachers t ON tt.teachID = t.teachID ";
    }

    // выборка студентов по кафедре
    public static string selectStudsByCath(string cathName)
    {
      return "SELECT studID, firstName AS Имя, lastName AS Фамилия, " +
             "  thirdName As Отчество, pasNO AS Паспорт, " +
             "  recordBook, age, startYear, phone AS Телефон, address AS Адрес, groupID, " +
             "  course AS Семестр, groupIndex AS Группа, cathName " +
             "  AS Кафедра, facName AS Факультет " +
             "FROM StudentsView " +
             "WHERE cathName = '" + cathName + "' " +
             "ORDER BY 3 ";
    }

    // выборка студентов по факультету
    public static string selectStudsByFac(string facName)
    {
      return "SELECT studID, firstName AS Имя, lastName AS Фамилия, " +
             "  thirdName As Отчество, pasNO AS Паспорт, " +
             "  recordBook, age, startYear, phone AS Телефон, address AS Адрес, groupID, " +
             "  course AS Семестр, groupIndex AS Группа, cathName " +
             "  AS Кафедра, facName AS Факультет " +
             "FROM StudentsView " +
             "WHERE facName = '" + facName + "' " +
             "ORDER BY 3 ";
    }

    // выборка группы по индексу
    public static string selectGroupByIndex(string index)
    {
      return "SELECT groupID, groupIndex AS Индекс, " +
             "  course AS Семестр, specName AS Специальность, firstName, " +
             "  lastName, thirdName, curatorID, cathName AS Кафедра," +
             "  facName AS Факультет, studCount AS [Количество студентов] " +
             "FROM GroupsView " +
             "WHERE groupIndex = '" + index + "'";
    }

    // добавление студента
    public static string insertStud(string firstName, string lastName,
                                    string thirdName, string pasNO,
                                    string recordBook, string age,
                                    string startYear, string phone,
                                    string address, 
                                    string groupID)
    {
      age = age == "" ? "NULL" : age;
      groupID = groupID == "" ? "NULL" : groupID;
      return "INSERT INTO Students (firstName, lastName, thirdName, " +
             "  pasNO, recordBook, age, startYear, phone, address, " +
             "  groupID) " +
             "VALUES ('" + firstName + "', '" + lastName + "', '" + thirdName +
             "', '" + pasNO + "', '" + recordBook + "', " + age + ", " +
             startYear + ", '" + phone + "', '" + address + "', " + groupID +
             ")";
    }

    // редактирование информации о студенте 
    public static string updateStud(string studID, string firstName,
                                    string lastName, string thirdName,
                                    string pasNO, string recordBook,
                                    string age, string startYear,
                                    string phone, string address,
                                    string groupID)
    {
      return "UPDATE Students SET " +
             "  firstName = '" + firstName + "', " +
             "  lastName = '" + lastName + "', " +
             "  thirdName = '" + thirdName + "', " +
             "  pasNO = '" + pasNO + "', " +
             "  recordBook = '" + recordBook + "', " +
             "  age = " + age + ", " +
             "  startYear = " + startYear + ", " +
             "  phone = '" + phone + "', " +
             "  address = '" + address + "', " +
             "  groupID = " + groupID + " " +
             "WHERE studID = " + studID;
    }

    // удаление студента
    public static string deleteStud(int index)
    {
      return "DELETE Students " +
             "WHERE studID = " + index.ToString();
    }

    // Выборка всех дисциплин
    public static string selectAllSubjects()
    {
      return "SELECT subID, subName AS Название, subDesc AS Описание " +
             "FROM Subjects";
    }

    // Выборка всех дисциплин по специальности
    public static string selectSubjectsByTeach(string teachID)
    {
      return "SELECT sb.subID, sb.subName AS Название, sb.subDesc AS Описание " +
             "FROM Teachers t JOIN TeachSubjects ts " +
             "ON t.teachID = ts.teachID JOIN Subjects sb " +
             "ON ts.subID = sb.subID " + 
             "WHERE t.teachID = " + teachID + " ";
    }

    // Выборка всех дисциплин которые читаются данным преподавателем
    // (если специальности, кафедры соотносятся один к одному)
    public static string selectSubjectsByCath(string cathID)
    {
      return "SELECT sb.subID, sb.subName AS Название, sb.subDesc AS Описание, " +
             "  ss.hours AS Часы " +
             "FROM Cathedras c JOIN Specialities sp ON c.cathID = sp.cathID " +
             "JOIN SpecSubjects ss ON sp.specID = ss.specID " +
             "JOIN Subjects sb ON ss.subID = sb.subID " +
             "WHERE c.cathID = " + cathID + " ";
    }

    // Выборка дисциплины по группе
    public static string selectSubjectsByGroup(string groupID)
    {
      return "SELECT sb.subID, sb.subName AS Название, sb.subDesc AS Описание, " +
             "  t.lastName + ' ' + t.firstName + ' ' + t.thirdName AS Преподаватель, " +
             "  t.teachID " +
             "FROM Groups g JOIN TeachSubjects ts ON g.groupID = ts.groupID " +
             "JOIN Subjects sb ON ts.subID = sb.subID " +
             "JOIN Teachers t ON t.teachID = ts.teachID " +
             "WHERE g.groupID = " + groupID + " ";
    }

    // добавление дисциплины
    public static string insertSubject(string name, string desc)
    {
      return "INSERT INTO Subjects (subName, subDesc) " +
             "VALUES ('" + name + "', '" + desc + "') ";
    }

    // изменение дисциплины
    public static string updateSubject(string subID, string name, string desc)
    {
      return "UPDATE Subjects SET " +
             "  subName = '" + name + "', " +
             "  subDesc = '" + desc + "' " +
             "WHERE subID = " + subID;
    }

    // назначение группе предмета читаемого данным преподавателем
    public static string insertTeachSubject(string subID, string groupID, string teachID)
    {
      return "INSERT INTO TeachSubjects (subID, groupID, teachID) " +
             "VALUES (" + subID + ", " + groupID + ", " + teachID + ")";
    }

    // выбор группы по ID
    public static string selectGroup(string groupID)
    {
      return "SELECT groupID, groupIndex AS Индекс, " +
             "  course AS Семестр, specName AS Специальность, firstName, " +
             "  lastName, thirdName, curatorID, cathName AS Кафедра," +
             "  facName AS Факультет, studCount AS [Количество студентов] " +
             "FROM GroupsView " +
             "WHERE groupID = " + groupID;
    }

    // выбор дисциплины по ID
    public static string selectSubject(string subID)
    {
      return "SELECT subID, subName AS Название, subDesc AS Описание " +
             "FROM Subjects " +
             "WHERE subID = " + subID;
    }

    // удаление дисциплины для группы
    public static string deleteTeachSubject(string subID, string groupID, string teachID)
    {
      return "DELETE TeachSubjects " +
             "WHERE subID = " + subID + " " +
             "AND groupID = " + groupID + " " +
             "AND teachID = " + teachID;
    }

    // изменение преподавателя у группы для предмета
    public static string updateTeachSubject(string subID, string groupID, string teachID)
    {
      return "UPDATE TeachSubjects SET " +
             "  teachID = " + teachID + " " +
             "WHERE groupID = " + groupID + " " +
             "AND subID = " + subID;
    }

    // добавление дисциплины к специальности
    public static string insertSpecSubject(string specID, string subID, 
                                           string hours)
    {
      return "INSERT INTO SpecSubjects (specID, subID, hours) " +
             "VALUES (" + specID + ", " + subID + ", " + hours + ")";
    }

    // выборка специальностей по кафедре
    public static string selectSpecByCath(string cathID)
    {
      return "SELECT * " +
             "FROM Specialities " +
             "WHERE cathID = " + cathID;
    }

    // удаление дисциплины из списка данной специальности
    public static string deleteSpecSubject(string subID)
    {
      return "DELETE SpecSubjects " +
             "WHERE subID = " + subID;
    }

    // выборка всех должностей
    public static string selectAllPosts()
    {
      return "SELECT * " +
             "FROM Post";
    }

    // выборка всех научных званий
    public static string selectAllRanks()
    {
      return "SELECT * " +
             "FROM Rank";
    }

    // удаление дисциплины
    public static string deleteSubject(string subID)
    {
      return "DELETE Subjects " +
             "WHERE subID = " + subID;
    }

    // поиск пользователя с данным логином
    public static string selectRights(string login)
    {
      return "SELECT * " +
             "FROM Rights " +
             "WHERE login = '" + login + "'";
    }

    // выборка всех пользователей
    public static string selectAllUsers()
    {
      return "SELECT * FROM Rights";
    }

    // добавление пользовател
    public static string insertUser(string login, string pas, string rights)
    {
      return "INSERT INTO Rights (login, pas, rights) " +
             "VALUES ('" + login + "', '" + pas + "', " +
             rights.ToString() + ")";
    }

    // изменение пользователя
    public static string updateUser(string login, string pas, string rights)
    {
      return "UPDATE Rights SET " +
             "  pas = '" + pas + "', " +
             "  rights = " + rights + " " +
             "WHERE login = '" + login + "'";
    }

    // удалить пользователя
    public static string deleteUser(string login)
    {
      return "DELETE Rights WHERE login = '" + login + "'";
    }

    // переход всех групп на новый семестр
    public static string newTerm()
    {
      return "UPDATE Groups SET course = course + 1";
    }
  }
}
