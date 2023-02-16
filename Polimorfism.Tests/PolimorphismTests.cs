using Polimorfism.Edu.Proj;
namespace Polimorfism.Tests
{
    public class PolimorphismTests
    {
        [Fact]
        public void SetBaseNewYear_GetGrigorianNewYear_01JanReturned()
        {
            // Arrange
            var expected = new DateTime((DateTime.Now.Year + 1), 1, 1);
            MyHolidaysBase b = new ();
            // Act
            b.SetOrUpdateNewYearDate();
            var actual = b._myHolidays.GetValueOrDefault("New Year");
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void SetBaseFoundationDay_GetRussianFoundationDay_12JunReturned()
        {
            // Arrange
            var expected = new DateTime((DateTime.Now.Year + 1), 6, 12);
            MyHolidaysBase b = new();
            // Act
            b.SetOrUpdateFoundationDay();
            var actual = b._myHolidays.GetValueOrDefault("Foundation Day");
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void SetOverridedNewYear_GetChineseNewYear_12FebReturned()
        {
            // Arrange
            var expected = new DateTime((DateTime.Now.Year + 1), 2, 12);
            ChineseHolidaysDerivedOverrided c = new();
            // Act
            c.SetOrUpdateNewYearDate();
            var actual = c._myHolidays.GetValueOrDefault("New Year");
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void SetOverridedFoundationDay_GetChineseFoundationDay_1OctReturned()
        {
            // Arrange
            var expected = new DateTime((DateTime.Now.Year + 1), 10, 1);
            ChineseHolidaysDerivedOverrided c = new();
            // Act
            c.SetOrUpdateFoundationDay();
            var actual = c._myHolidays.GetValueOrDefault("Foundation Day");
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void SetOverridedCastedNewYear_GetChineseNewYear_12FebReturned()
        {
            // Arrange
            var expected = new DateTime((DateTime.Now.Year + 1), 2, 12);
            ChineseHolidaysDerivedOverrided c = new();
            MyHolidaysBase b = new();
            b = c;
            // Act
            b.SetOrUpdateNewYearDate();
            var actual = b._myHolidays.GetValueOrDefault("New Year");
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void SetOverridedCastedFoundationDay_GetChineseFoundationDay_1OctReturned()
        {
            // Arrange
            var expected = new DateTime((DateTime.Now.Year + 1), 10, 1);
            ChineseHolidaysDerivedOverrided c = new();
            MyHolidaysBase b = new();
            b = c;
            // Act
            b.SetOrUpdateFoundationDay();
            var actual = b._myHolidays.GetValueOrDefault("Foundation Day");
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SetNewYearDerivedWithNew_GetIranianNewYear_21MarchReturned()
        {
            // Arrange
            var expected = new DateTime((DateTime.Now.Year + 1), 3, 21);
            IranianHolidaysDerivedNew i = new();
            // Act
            i.SetOrUpdateNewYearDate();
            var actual = i._myHolidays.GetValueOrDefault("New Year");
            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void SetFoundationDayDerivedWithNew_GetIranianFoundationDay_1AprilReturned()
        {
            // Arrange
            var expected = new DateTime((DateTime.Now.Year + 1), 4, 1);
            IranianHolidaysDerivedNew i = new();
            // Act
            i.SetOrUpdateFoundationDay();
            var actual = i._myHolidays.GetValueOrDefault("Foundation Day");
            // Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void SetNewYearDerivedWithNewCasted_GetIranianNewYear_21MarchReturned()
        {
            // Arrange
            var expected = new DateTime((DateTime.Now.Year + 1), 3, 21);
            IranianHolidaysDerivedNew i = new();
            MyHolidaysBase b = new();
            b = i;
            // Act
            b.SetOrUpdateNewYearDate();
            var actual = b._myHolidays.GetValueOrDefault("New Year");
            // Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void SetFoundationDayDerivedWithNewCasted_GetIranianFoundationDay_1AprilReturned()
        {
            // Arrange
            var expected = new DateTime((DateTime.Now.Year + 1), 4, 1);
            IranianHolidaysDerivedNew i = new();
            MyHolidaysBase b = new();
            b = i;
            // Act
            b.SetOrUpdateFoundationDay();
            var actual = b._myHolidays.GetValueOrDefault("Foundation Day");
            // Assert
            Assert.Equal(expected, actual);
        }

    }
}