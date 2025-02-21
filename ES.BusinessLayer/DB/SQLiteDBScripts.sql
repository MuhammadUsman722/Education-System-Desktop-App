CREATE TABLE [AccessRights] (
	[AccessRightID]	integer PRIMARY KEY AUTOINCREMENT NOT NULL,
	[Description]	TEXT NOT NULL ,
	[ControlID]	TEXT NOT NULL ,
	[UserID]	integer NOT NULL,
	[CanEdit]	bit NOT NULL,
	[CanView]	bit NOT NULL,
	[CanDelete]	bit NOT NULL,
	[isActive]	bit DEFAULT 1
,
    FOREIGN KEY ([UserID])
        REFERENCES [Users]([UserID])
);
CREATE TABLE [Attendance] (
	[ID]	integer PRIMARY KEY AUTOINCREMENT NOT NULL,
	[ClassID]	integer NOT NULL,
	[StudentID]	integer NOT NULL,
	[SessionID]	integer NOT NULL,
	[AttendanceDate]	TEXT NOT NULL ,
	[updated_date]	TEXT NOT NULL,
	[creation_date]	TEXT NOT NULL,
	[updated_by]	integer NOT NULL,
	[created_by]	integer NOT NULL,
	[isActive]	bit NOT NULL DEFAULT 1,
	[isPresent]	bit NOT NULL DEFAULT 0,
	[SectionID]	integer

);
CREATE TABLE [Class] (
	[ClassID]	integer PRIMARY KEY AUTOINCREMENT NOT NULL,
	[Description]	TEXT ,
	[ClassNumber]	integer NOT NULL,
	[creation_date]	TEXT NOT NULL,
	[updated_date]	TEXT NOT NULL,
	[created_by]	integer NOT NULL,
	[updated_by]	integer NOT NULL,
	[BranchID]	integer,
	[isActive]	bit DEFAULT 1
,
    FOREIGN KEY ([created_by])
        REFERENCES [Users]([UserID]),
    FOREIGN KEY ([updated_by])
        REFERENCES [Users]([UserID])
);
CREATE TABLE [ClassStudent] (
	[ID]	integer PRIMARY KEY AUTOINCREMENT NOT NULL,
	[ClassID]	integer NOT NULL,
	[StudentID]	integer NOT NULL,
	[creation_date]	TEXT NOT NULL ,
	[updated_date]	TEXT NOT NULL ,
	[created_by]	integer NOT NULL,
	[updated_by]	integer NOT NULL,
	[isActive]	bit NOT NULL DEFAULT 1
,
    FOREIGN KEY ([StudentID])
        REFERENCES [Student]([StudentID]),
    FOREIGN KEY ([created_by])
        REFERENCES [Users]([UserID]),
    FOREIGN KEY ([updated_by])
        REFERENCES [Users]([UserID])
);
CREATE TABLE [ClassSubject] (
	[ID]	integer PRIMARY KEY AUTOINCREMENT NOT NULL,
	[ClassID]	integer NOT NULL,
	[SubjectID]	integer NOT NULL,
	[creation_date]	TEXT NOT NULL ,
	[updated_date]	TEXT NOT NULL ,
	[created_by]	integer NOT NULL,
	[updated_by]	integer NOT NULL,
	[isActive]	bit NOT NULL DEFAULT 1
,
    FOREIGN KEY ([SubjectID])
        REFERENCES [Subject]([SubjectID]),
    FOREIGN KEY ([SubjectID])
        REFERENCES [Subject]([SubjectID]),
    FOREIGN KEY ([created_by])
        REFERENCES [Users]([UserID]),
    FOREIGN KEY ([updated_by])
        REFERENCES [Users]([UserID])
);
CREATE TABLE [ClassTeacher] (
	[ID]	integer PRIMARY KEY AUTOINCREMENT NOT NULL,
	[ClassID]	integer NOT NULL,
	[TeacherID]	integer NOT NULL,
	[creation_date]	TEXT NOT NULL ,
	[updated_date]	TEXT NOT NULL ,
	[created_by]	integer NOT NULL,
	[updated_by]	integer NOT NULL,
	[isActive]	bit NOT NULL DEFAULT 1
,
    FOREIGN KEY ([TeacherID])
        REFERENCES [Users]([UserID]),
    FOREIGN KEY ([created_by])
        REFERENCES [Users]([UserID]),
    FOREIGN KEY ([updated_by])
        REFERENCES [Users]([UserID])
);
CREATE TABLE [Education] (
	[EducationID]	integer PRIMARY KEY AUTOINCREMENT NOT NULL,
	[Description]	TEXT NOT NULL ,
	[PassYear]	integer NOT NULL,
	[score]	TEXT NOT NULL ,
	[UserID]	integer NOT NULL,
	[Institution]	TEXT ,
	[isActive]	bit DEFAULT 1
,
    FOREIGN KEY ([UserID])
        REFERENCES [Users]([UserID])
);
CREATE TABLE [Exam] (
	[ExamID]	integer PRIMARY KEY AUTOINCREMENT NOT NULL,
	[Description]	TEXT NOT NULL ,
	[Type]	bit NOT NULL,
	[comment]	TEXT ,
	[created_by]	integer NOT NULL,
	[updated_by]	integer NOT NULL,
	[creation_date]	TEXT NOT NULL,
	[updated_date]	TEXT NOT NULL,
	[isActive]	bit NOT NULL DEFAULT 1
);
CREATE TABLE [Experience] (
	[ExperienceID]	integer PRIMARY KEY AUTOINCREMENT NOT NULL,
	[Description]	TEXT NOT NULL ,
	[StartDate]	TEXT ,
	[EndDate]	TEXT ,
	[Institution]	TEXT ,
	[UserID]	integer NOT NULL,
	[isActive]	bit DEFAULT 1
,
    FOREIGN KEY ([ExperienceID])
        REFERENCES [Users]([UserID])
);
CREATE TABLE [FeeDetail] (
	[ID]	integer PRIMARY KEY AUTOINCREMENT NOT NULL,
	[FeeType]	varchar(5) NOT NULL ,
	[PaidFee]	integer NOT NULL,
	[PaidDate]	TEXT NOT NULL ,
	[RecievedBy]	integer NOT NULL,
	[StudentID]	integer NOT NULL,
	[ClassID]	integer NOT NULL,
	[SectionID]	integer NOT NULL,
	[SessionID]	integer NOT NULL,
	[PaidForMonth]	integer NOT NULL DEFAULT 0,
	[isActive]	bit NOT NULL DEFAULT 1,
	[isAdjusted]	bit NOT NULL,
	[DecidedFee]	integer DEFAULT 0,
	[RemainingFee]	integer DEFAULT 0

);
CREATE TABLE [Grade] (
	[GradeID]	integer PRIMARY KEY AUTOINCREMENT NOT NULL,
	[GradeName]	TEXT NOT NULL ,
	[Percentage]	numeric NOT NULL DEFAULT 0,
	[Comment]	TEXT ,
	[created_by]	integer NOT NULL,
	[updated_by]	integer NOT NULL,
	[creation_date]	TEXT NOT NULL,
	[updated_date]	TEXT NOT NULL,
	[isActive]	bit NOT NULL DEFAULT 1

);
CREATE TABLE [Parent] (
	[ParentID]	integer PRIMARY KEY AUTOINCREMENT NOT NULL,
	[FirstName]	TEXT NOT NULL ,
	[MiddleName]	TEXT ,
	[LastName]	TEXT ,
	[Address]	TEXT ,
	[Email]	TEXT ,
	[ContactNo1]	TEXT ,
	[ContactNo2]	TEXT ,
	[CNIC]	TEXT NOT NULL ,
	[Income]	integer NOT NULL DEFAULT 0,
	[creation_date]	TEXT NOT NULL,
	[updated_date]	TEXT NOT NULL,
	[updated_by]	integer NOT NULL,
	[created_by]	integer NOT NULL,
	[isActive]	bit DEFAULT 1
,
    FOREIGN KEY ([updated_by])
        REFERENCES [Users]([UserID]),
    FOREIGN KEY ([created_by])
        REFERENCES [Users]([UserID])
);
CREATE TABLE [Roles] (
	[RoleID]	integer PRIMARY KEY AUTOINCREMENT NOT NULL,
	[Description]	TEXT NOT NULL ,
	[RoleCode]	TEXT ,
	[isActive]	bit DEFAULT 1

);
CREATE TABLE [Sections] (
	[SectionID]	integer PRIMARY KEY AUTOINCREMENT NOT NULL,
	[Description]	TEXT NOT NULL ,
	[isActive]	bit NOT NULL DEFAULT 1

);
CREATE TABLE [Session] (
	[SessionID]	integer PRIMARY KEY AUTOINCREMENT NOT NULL,
	[StartDate]	TEXT NOT NULL ,
	[EndDate]	TEXT NOT NULL ,
	[creation_date]	TEXT NOT NULL,
	[updated_date]	TEXT NOT NULL,
	[created_by]	integer NOT NULL,
	[updated_by]	integer NOT NULL,
	[Description]	TEXT ,
	[isActive]	bit DEFAULT 1
,
    FOREIGN KEY ([created_by])
        REFERENCES [Users]([UserID]),
    FOREIGN KEY ([updated_by])
        REFERENCES [Users]([UserID])
);
CREATE TABLE [Student] (
	[StudentID]	integer PRIMARY KEY AUTOINCREMENT NOT NULL,
	[FirstName]	TEXT ,
	[LastName]	TEXT ,
	[MiddleName]	char(10) ,
	[DateOfBirth]	TEXT NOT NULL ,
	[AdmissionDate]	TEXT NOT NULL ,
	[RegistrationNumber]	TEXT NOT NULL ,
	[Gender]	char(50) NOT NULL ,
	[Phone]	TEXT ,
	[AdminssionFee]	integer NOT NULL DEFAULT 0,
	[ExaminationFee]	integer NOT NULL DEFAULT 0,
	[MonthlyFee]	integer NOT NULL DEFAULT 0,
	[OtherCharges]	integer NOT NULL DEFAULT 0,
	[Discount]	integer NOT NULL DEFAULT 0,
	[ParentID]	integer NOT NULL,
	[ClassID]	integer NOT NULL,
	[creation_date]	TEXT NOT NULL,
	[updated_date]	TEXT NOT NULL,
	[created_by]	integer NOT NULL,
	[updated_by]	integer NOT NULL,
	[isActive]	bit DEFAULT 1,
	[SectionID]	integer DEFAULT 0
,
    FOREIGN KEY ([ParentID])
        REFERENCES [Parent]([ParentID]),
    FOREIGN KEY ([ClassID])
        REFERENCES [Class]([ClassID]),
    FOREIGN KEY ([created_by])
        REFERENCES [Users]([UserID]),
    FOREIGN KEY ([updated_by])
        REFERENCES [Users]([UserID])
);
CREATE TABLE [StudentFee] (
	[StudentFeeID]	integer PRIMARY KEY AUTOINCREMENT NOT NULL,
	[FeeType]	varchar(5) NOT NULL ,
	[DecidedFee]	integer NOT NULL,
	[StudentID]	integer NOT NULL,
	[SessionID]	integer NOT NULL,
	[created_by]	integer NOT NULL,
	[creation_date]	TEXT NOT NULL ,
	[updated_by]	integer NOT NULL,
	[updated_date]	TEXT NOT NULL 

);
CREATE TABLE [StudentSubjectMarks] (
	[ID]	integer PRIMARY KEY AUTOINCREMENT NOT NULL,
	[ClassID]	integer NOT NULL,
	[StudentID]	integer NOT NULL,
	[ExamID]	integer NOT NULL,
	[SubjectID]	integer NOT NULL,
	[SectionID]	integer NOT NULL,
	[ObtainedMarks]	numeric NOT NULL,
	[TotalMarks]	integer NOT NULL,
	[isActive]	bit NOT NULL DEFAULT 1,
	[created_by]	integer NOT NULL,
	[updated_by]	integer NOT NULL,
	[creation_date]	TEXT NOT NULL,
	[updated_date]	TEXT NOT NULL,
	[SessionID]	integer DEFAULT 0

);
CREATE TABLE [Subject] (
	[SubjectID]	integer PRIMARY KEY AUTOINCREMENT NOT NULL,
	[Description]	TEXT NOT NULL ,
	[creation_date]	TEXT NOT NULL,
	[updated_date]	TEXT NOT NULL,
	[created_by]	integer NOT NULL,
	[updated_by]	integer NOT NULL,
	[Type]	TEXT ,
	[Compulsory]	TEXT ,
	[isActive]	bit DEFAULT 1
,
    FOREIGN KEY ([created_by])
        REFERENCES [Users]([UserID]),
    FOREIGN KEY ([updated_by])
        REFERENCES [Users]([UserID])
);
CREATE TABLE [Users] (
	[UserID]	integer PRIMARY KEY AUTOINCREMENT NOT NULL,
	[UserName]	TEXT NOT NULL ,
	[Password]	TEXT NOT NULL ,
	[RoleID]	TEXT ,
	[isActive]	bit DEFAULT 1

);
CREATE TABLE [UsersDetail] (
	[ID]	integer PRIMARY KEY AUTOINCREMENT NOT NULL,
	[FirstName]	TEXT NOT NULL ,
	[LastName]	TEXT NOT NULL ,
	[MiddleName]	TEXT ,
	[dob]	TEXT ,
	[CNIC]	TEXT ,
	[ContactNo1]	TEXT ,
	[ContactNo2]	TEXT ,
	[EmailID]	TEXT ,
	[Salary]	integer NOT NULL DEFAULT 0,
	[UserID]	integer NOT NULL,
	[creation_date]	TEXT NOT NULL ,
	[updated_date]	TEXT NOT NULL ,
	[created_by]	integer NOT NULL,
	[updated_by]	integer NOT NULL,
	[Gender]	TEXT ,
	[Address]	TEXT ,
	[isActive]	bit DEFAULT 1,
	[Joining_date]	TEXT ,
	[FatherName]	TEXT 
,
    FOREIGN KEY ([UserID])
        REFERENCES [Users]([UserID])
)