using Microsoft.EntityFrameworkCore.Migrations;

namespace bookofspells.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactForm",
                columns: table => new
                {
                    MessageID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 254, nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Message = table.Column<string>(maxLength: 8000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactForm", x => x.MessageID);
                });

            migrationBuilder.CreateTable(
                name: "NewsletterSignup",
                columns: table => new
                {
                    EmailID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmailAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsletterSignup", x => x.EmailID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(maxLength: 30, nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    EmailAddress = table.Column<string>(maxLength: 254, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Spell",
                columns: table => new
                {
                    SpellID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(maxLength: 60, nullable: false),
                    Enchantment = table.Column<string>(maxLength: 8000, nullable: false),
                    Intention = table.Column<string>(nullable: false),
                    MagicType = table.Column<string>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    Filename = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spell", x => x.SpellID);
                    table.ForeignKey(
                        name: "FK_Spell_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ContactForm",
                columns: new[] { "MessageID", "Email", "Message", "Name", "Phone" },
                values: new object[] { 1, "luminous_nox_lupin@mysteriesofthenox.com", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in.", "Luminous Nox-Lupin", "737-555-9993" });

            migrationBuilder.InsertData(
                table: "NewsletterSignup",
                columns: new[] { "EmailID", "EmailAddress" },
                values: new object[] { 1, "illuminate@bookofspells.com" });

            migrationBuilder.InsertData(
                table: "NewsletterSignup",
                columns: new[] { "EmailID", "EmailAddress" },
                values: new object[] { 2, "raviniablaque@bookofspells.com" });

            migrationBuilder.InsertData(
                table: "NewsletterSignup",
                columns: new[] { "EmailID", "EmailAddress" },
                values: new object[] { 3, "trundae.sythe@bookofspells.com" });

            migrationBuilder.InsertData(
                table: "NewsletterSignup",
                columns: new[] { "EmailID", "EmailAddress" },
                values: new object[] { 4, "wilowe_shutes@bookofspells.com" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserID", "EmailAddress", "FirstName", "LastName", "Username" },
                values: new object[] { 1, "raviniablaque@bookofspells.com", "Ravinia", "Blaque", "raviniablaque" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserID", "EmailAddress", "FirstName", "LastName", "Username" },
                values: new object[] { 2, "trundae.sythe@bookofspells.com", "Trundae", "Sythe", "trundae.sythe" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserID", "EmailAddress", "FirstName", "LastName", "Username" },
                values: new object[] { 3, "wilowe_shutes@bookofspells.com", "Wilowe ", "Shutes", "wilowe" });

            migrationBuilder.InsertData(
                table: "Spell",
                columns: new[] { "SpellID", "Enchantment", "Filename", "Intention", "MagicType", "Title", "UserID" },
                values: new object[] { 1, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in.

                        In vitae turpis massa sed elementum tempus egestas sed. Nunc aliquet bibendum enim facilisis gravida neque convallis. Commodo odio aenean sed adipiscing diam. Ornare massa eget egestas purus. Lacus sed turpis tincidunt id aliquet risus feugiat in. Bibendum ut tristique et egestas.

                        Purus viverra accumsan in nisl nisi scelerisque eu ultrices vitae. In hendrerit gravida rutrum quisque non tellus orci ac auctor.", "mandala_sacred_ancient_geometry_vector_3732998.png", "Protection", "Grey", "In Vitae Tempus Elementum", 1 });

            migrationBuilder.InsertData(
                table: "Spell",
                columns: new[] { "SpellID", "Enchantment", "Filename", "Intention", "MagicType", "Title", "UserID" },
                values: new object[] { 5, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore.

                        Eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in. In vitae turpis massa sed elementum tempus egestas sed. Nunc aliquet bibendum enim facilisis gravida neque convallis.

                        Commodo odio aenean sed adipiscing diam. Ornare massa eget egestas purus. Lacus sed turpis tincidunt id aliquet risus feugiat in. Bibendum ut tristique et egestas. Purus viverra accumsan in nisl nisi scelerisque eu ultrices vitae.

                        In hendrerit gravida rutrum quisque non tellus orci ac auctor.", "mandala_sacred_ancient_geometry_vector_3732998.png", "Protection", "White", "Hendrerit Gravida Rutrum", 1 });

            migrationBuilder.InsertData(
                table: "Spell",
                columns: new[] { "SpellID", "Enchantment", "Filename", "Intention", "MagicType", "Title", "UserID" },
                values: new object[] { 9, @"Diam maecenas ultricies mi eget mauris pharetra et. Mi in nulla posuere sollicitudin aliquam ultrices sagittis. Purus non enim praesent elementum facilisis.

                        Pellentesque pulvinar pellentesque habitant morbi tristique senectus. Nunc lobortis mattis aliquam faucibus purus in. Amet volutpat consequat mauris nunc.

                        In aliquam sem fringilla ut morbi. Mus mauris vitae ultricies leo integer malesuada nunc. Nulla posuere sollicitudin aliquam ultrices sagittis orci a scelerisque. Eget mi proin sed libero enim. Porta non pulvinar neque laoreet suspendisse.", "mandala_sacred_ancient_geometry_vector_3732998.png", "Protection", "Black", "Fringilla est Ullamcorper", 1 });

            migrationBuilder.InsertData(
                table: "Spell",
                columns: new[] { "SpellID", "Enchantment", "Filename", "Intention", "MagicType", "Title", "UserID" },
                values: new object[] { 2, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.

                        Excepteur sint occaecat cupidatat non proident, sunt in. In vitae turpis massa sed elementum tempus egestas sed. Nunc aliquet bibendum enim facilisis gravida neque convallis. Commodo odio aenean sed adipiscing diam. Ornare massa eget egestas purus. Lacus sed turpis tincidunt id aliquet risus feugiat in.

                        Bibendum ut tristique et egestas. Purus viverra accumsan in nisl nisi scelerisque eu ultrices vitae. In hendrerit gravida rutrum quisque non tellus orci ac auctor.", "devil-goat-with-sacred-geometry.png", "Wealth", "Black", "Excepteur Sint Occaecat", 2 });

            migrationBuilder.InsertData(
                table: "Spell",
                columns: new[] { "SpellID", "Enchantment", "Filename", "Intention", "MagicType", "Title", "UserID" },
                values: new object[] { 6, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in. In vitae turpis massa sed elementum tempus egestas sed.

                        Nunc aliquet bibendum enim facilisis gravida neque convallis. Commodo odio aenean sed adipiscing diam. Ornare massa eget egestas purus. Lacus sed turpis tincidunt id aliquet risus feugiat in. Bibendum ut tristique et egestas. Purus viverra accumsan in nisl nisi scelerisque eu ultrices vitae. In hendrerit gravida rutrum quisque non tellus orci ac auctor.", "mandala_geometry_sacred_symbol_4242415.png", "Power", "Black", "Nunc Aliquet Bibendum", 2 });

            migrationBuilder.InsertData(
                table: "Spell",
                columns: new[] { "SpellID", "Enchantment", "Filename", "Intention", "MagicType", "Title", "UserID" },
                values: new object[] { 8, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. 

                        Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.

                        Excepteur sint occaecat cupidatat non proident, sunt in. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "devil-goat-with-sacred-geometry.png", "Knowledge", "White", "Laboris Nisi ut Aliquip", 2 });

            migrationBuilder.InsertData(
                table: "Spell",
                columns: new[] { "SpellID", "Enchantment", "Filename", "Intention", "MagicType", "Title", "UserID" },
                values: new object[] { 3, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.

                        Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in. In vitae turpis massa sed elementum tempus egestas sed.

                        Nunc aliquet bibendum enim facilisis gravida neque convallis. Commodo odio aenean sed adipiscing diam. Ornare massa eget egestas purus. Lacus sed turpis tincidunt id aliquet risus feugiat in. Bibendum ut tristique et egestas. Purus viverra accumsan in nisl nisi scelerisque eu ultrices vitae. In hendrerit gravida rutrum quisque non tellus orci ac auctor.", "mandala_geometry_sacred_symbol_4242415.png", "Knowledge", "White", "Enim Ad Minim Veniam", 3 });

            migrationBuilder.InsertData(
                table: "Spell",
                columns: new[] { "SpellID", "Enchantment", "Filename", "Intention", "MagicType", "Title", "UserID" },
                values: new object[] { 4, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit.

                        In voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in. In vitae turpis massa sed elementum tempus egestas sed. Nunc aliquet bibendum enim facilisis gravida neque convallis. Commodo odio aenean sed adipiscing diam. Ornare massa eget egestas purus.

                        Lacus sed turpis tincidunt id aliquet risus feugiat in. Bibendum ut tristique et egestas. Purus viverra accumsan in nisl nisi scelerisque eu ultrices vitae. In hendrerit gravida rutrum quisque non tellus orci ac auctor.", "devil-goat-with-sacred-geometry.png", "Love", "Grey", "Aute Irure Dolor", 3 });

            migrationBuilder.InsertData(
                table: "Spell",
                columns: new[] { "SpellID", "Enchantment", "Filename", "Intention", "MagicType", "Title", "UserID" },
                values: new object[] { 7, @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. 

                        Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.

                        Excepteur sint occaecat cupidatat non proident, sunt in. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", "mandala_sacred_ancient_geometry_vector_3732998.png", "Wealth", "Grey", "Magna Exercitation", 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Spell_UserID",
                table: "Spell",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactForm");

            migrationBuilder.DropTable(
                name: "NewsletterSignup");

            migrationBuilder.DropTable(
                name: "Spell");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
