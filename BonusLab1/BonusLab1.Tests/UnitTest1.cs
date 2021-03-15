using System;
using Xunit;

namespace BonusLab1.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void GetA_100()
        {
            // Arrange
            var a = new GetGrade();

            // Act
            a.StudentGrade(100);

            // Assert
            Assert.Equal("A","A");

        }

        [Fact]
        public void GetA_88()
        {
            var a = new GetGrade();

            a.StudentGrade(88);

            Assert.Equal("A", "A");
        }

        [Fact]
        public void GetB_87()
        {
            var b = new GetGrade();

            b.StudentGrade(87);

            Assert.Equal("B", "B");
        }

        [Fact]
        public void GetB_80()
        {
            var b = new GetGrade();

            b.StudentGrade(80);

            Assert.Equal("B", "B");
        }

        [Fact]
        public void GetC_79()
        {
            var c = new GetGrade();

            c.StudentGrade(79);

            Assert.Equal("C", "C");
        }

        [Fact]
        public void GetC_67()
        {
            var c = new GetGrade();

            c.StudentGrade(67);

            Assert.Equal("C", "C");
        }

        [Fact]
        public void GetD_66()
        {
            var c = new GetGrade();

            c.StudentGrade(66);

            Assert.Equal("D", "D");
        }

        [Fact]
        public void GetD_60()
        {
            var c = new GetGrade();

            c.StudentGrade(60);

            Assert.Equal("D", "D");
        }

        [Fact]
        public void GetF_59()
        {
            var c = new GetGrade();

            c.StudentGrade(59);

            Assert.Equal("F", "F");
        }

        [Fact]
        public void GetF_0()
        {
            var c = new GetGrade();

            c.StudentGrade(0);

            Assert.Equal("F", "F");
        }
    }
}
