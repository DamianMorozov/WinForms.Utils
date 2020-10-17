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

        [Test]
        public void SetValue_DoesNotThrow()
        {
            Utils.MethodStart();
            foreach (var progressBar in _progressBars)
            {
                foreach (var value in EnumValues.GetProgress())
                {
                    Assert.DoesNotThrow(() => InvokeProgressBar.SetValue(progressBar, value));
                    Assert.DoesNotThrowAsync(async () => await Task.Run(() => InvokeProgressBar.SetValue(progressBar, value)));
                }
            }
            Utils.MethodComplete();
        }

        [Test]
        public void SetMinimum_DoesNotThrow()
        {
            Utils.MethodStart();
            foreach (var progressBar in _progressBars)
            {
                foreach (var value in EnumValues.GetProgress())
                {
                    Assert.DoesNotThrow(() => InvokeProgressBar.SetMinimum(progressBar, value));
                    Assert.DoesNotThrowAsync(async () => await Task.Run(() => InvokeProgressBar.SetMinimum(progressBar, value)));
                }
            }
            Utils.MethodComplete();
        }

        [Test]
        public void SetMaximum_DoesNotThrow()
        {
            Utils.MethodStart();
            foreach (var progressBar in _progressBars)
            {
                foreach (var value in EnumValues.GetProgress())
                {
                    Assert.DoesNotThrow(() => InvokeProgressBar.SetMaximum(progressBar, value));
                    Assert.DoesNotThrowAsync(async () => await Task.Run(() => InvokeProgressBar.SetMaximum(progressBar, value)));
                }
            }
            Utils.MethodComplete();
        }
    }
}
