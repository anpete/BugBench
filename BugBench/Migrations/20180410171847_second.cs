using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BugBench.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
              migrationBuilder.InsertData("Users", new string[] { "Email", "Fullname", "IsEmailConfirmed" }, new object[] { "user1@mail.com", "User1", true });
            migrationBuilder.InsertData("Users", new string[] { "Email", "Fullname", "IsEmailConfirmed" }, new object[] { "user2@mail.com", "User2", true });
            migrationBuilder.InsertData("Users", new string[] { "Email", "Fullname", "IsEmailConfirmed" }, new object[] { "user3@mail.com", "User3", true });

            migrationBuilder.InsertData("UserFriends", new string[] { "UserId", "FriendId" }, new object[] { 1, 2 });
            migrationBuilder.InsertData("UserFriends", new string[] { "UserId", "FriendId" }, new object[] { 2, 1 });
            migrationBuilder.InsertData("UserFriends", new string[] { "UserId", "FriendId" }, new object[] { 1, 3 });
            migrationBuilder.InsertData("UserFriends", new string[] { "UserId", "FriendId" }, new object[] { 3, 1 });

            migrationBuilder.InsertData("Tags", new string[] { "Value" }, new object[] { "tag1" });
            migrationBuilder.InsertData("Tags", new string[] { "Value" }, new object[] { "tag2" });
            migrationBuilder.InsertData("Tags", new string[] { "Value" }, new object[] { "tag3" });
            migrationBuilder.InsertData("Tags", new string[] { "Value" }, new object[] { "tag4" });

            migrationBuilder.InsertData("Quests", new string[] { "Name", "QuestionText", "Answer1Text", "Answer2Text", "Answer3Text", "Answer4Text", "AuthorId" }, new object[] { "Quest1", "???", "111", "222", "333", "444", 1 });
            migrationBuilder.InsertData("Quests", new string[] { "Name", "QuestionText", "Answer1Text", "Answer2Text", "Answer3Text", "Answer4Text", "AuthorId" }, new object[] { "Quest2", "!!!", "AAA", "BBB", "CCC", "DDD", 2 });
            migrationBuilder.InsertData("Quests", new string[] { "Name", "QuestionText", "Answer1Text", "Answer2Text", "Answer3Text", "Answer4Text", "AuthorId" }, new object[] { "Quest3", "***", "XXX", "YYY", "ZZZ", "---", 1 });

            migrationBuilder.InsertData("QuestTags", new string[] { "QuestId", "TagId" }, new object[] { 1, 1 });
            migrationBuilder.InsertData("QuestTags", new string[] { "QuestId", "TagId" }, new object[] { 1, 2 });
            migrationBuilder.InsertData("QuestTags", new string[] { "QuestId", "TagId" }, new object[] { 1, 4 });
            migrationBuilder.InsertData("QuestTags", new string[] { "QuestId", "TagId" }, new object[] { 2, 2 });
            migrationBuilder.InsertData("QuestTags", new string[] { "QuestId", "TagId" }, new object[] { 2, 3 });
            migrationBuilder.InsertData("QuestTags", new string[] { "QuestId", "TagId" }, new object[] { 3, 1 });
            migrationBuilder.InsertData("QuestTags", new string[] { "QuestId", "TagId" }, new object[] { 3, 4 });

            migrationBuilder.InsertData("Competitions", new string[] { "QuestId", "LikeCount", "DislikeCount" }, new object[] { 1, 5, 0 });
            migrationBuilder.InsertData("Competitions", new string[] { "QuestId", "LikeCount", "DislikeCount" }, new object[] { 2, 10, 1 });
            migrationBuilder.InsertData("Competitions", new string[] { "QuestId", "LikeCount", "DislikeCount" }, new object[] { 3, 2, 5 });

            migrationBuilder.InsertData("QuestPasses", new string[] { "UserId", "QuestId", "CompetitionId", "PointsScored", "CreatedAt" }, new object[] { 2, 1, 1, 10, DateTimeOffset.Now.AddDays(-3).ToString("u") });
            migrationBuilder.InsertData("QuestPasses", new string[] { "UserId", "QuestId", "CompetitionId", "PointsScored", "CreatedAt" }, new object[] { 2, 3, 3, 8, DateTimeOffset.Now.AddDays(-5).ToString("u") });
            migrationBuilder.InsertData("QuestPasses", new string[] { "UserId", "QuestId", "CompetitionId", "PointsScored", "CreatedAt" }, new object[] { 3, 1, 1, 15, DateTimeOffset.Now.AddDays(-2).ToString("u") });
            migrationBuilder.InsertData("QuestPasses", new string[] { "UserId", "QuestId", "CompetitionId", "PointsScored", "CreatedAt" }, new object[] { 3, 2, 2, 5, DateTimeOffset.Now.AddDays(-1).ToString("u") });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
