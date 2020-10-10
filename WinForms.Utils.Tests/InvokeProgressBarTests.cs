using NUnit.Framework;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Utils.Tests
{
    public class InvokeProgressBarTests
    {
        #region Private fields and properties

        private ConcurrentQueue<ProgressBar> _progressBars;

        #endregion

        #region Setup & teardown

        /// <summary>
        /// Setup private fields.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Setup)} start.");
            _progressBars = new ConcurrentQueue<ProgressBar>();
            for (var i = 0; i < 10; i++)
                _progressBars.Enqueue(new ProgressBar());
            TestContext.WriteLine($@"{nameof(Setup)} complete.");
        }

        /// <summary>
        /// Reset private fields to default state.
        /// </summary>
        [TearDown]
        public void Teardown()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Teardown)} start.");
            while (_progressBars.TryDequeue(out _)) { }
            TestContext.WriteLine($@"{nameof(Teardown)} complete.");
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
        }

        #endregion

        #region Public properties

        [Test]
        public void SetValue_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(SetValue_DoesNotThrow)} start.");
            foreach (var progressBar in _progressBars)
            {
                foreach (var value in EnumValues.GetProgress())
                {
                    Assert.DoesNotThrow(() => InvokeProgressBar.SetValue(progressBar, value));
                    Assert.DoesNotThrowAsync(async () => await Task.Run(() => InvokeProgressBar.SetValue(progressBar, value)));
                }
            }
            TestContext.WriteLine($@"{nameof(SetValue_DoesNotThrow)} complete.");
        }

        [Test]
        public void SetMinimum_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(SetMinimum_DoesNotThrow)} start.");
            foreach (var progressBar in _progressBars)
            {
                foreach (var value in EnumValues.GetProgress())
                {
                    Assert.DoesNotThrow(() => InvokeProgressBar.SetMinimum(progressBar, value));
                    Assert.DoesNotThrowAsync(async () => await Task.Run(() => InvokeProgressBar.SetMinimum(progressBar, value)));
                }
            }
            TestContext.WriteLine($@"{nameof(SetMinimum_DoesNotThrow)} complete.");
        }

        [Test]
        public void SetMaximum_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(SetMaximum_DoesNotThrow)} start.");
            foreach (var progressBar in _progressBars)
            {
                foreach (var value in EnumValues.GetProgress())
                {
                    Assert.DoesNotThrow(() => InvokeProgressBar.SetMaximum(progressBar, value));
                    Assert.DoesNotThrowAsync(async () => await Task.Run(() => InvokeProgressBar.SetMaximum(progressBar, value)));
                }
            }
            TestContext.WriteLine($@"{nameof(SetMaximum_DoesNotThrow)} complete.");
        }

        #endregion
    }
}
