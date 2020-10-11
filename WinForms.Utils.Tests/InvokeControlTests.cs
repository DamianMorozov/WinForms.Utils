using NUnit.Framework;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Utils.Tests
{
    public class InvokeControlTests
    {
        #region Private fields and properties

        private ConcurrentQueue<Control> _controls;

        #endregion

        /// <summary>
        /// Setup private fields.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Setup)} start.");
            _controls = new ConcurrentQueue<Control>();
            for (var i = 0; i < 10; i++)
            {
                _controls.Enqueue(new Label());
                _controls.Enqueue(new Button());
                _controls.Enqueue(new CheckBox());
                _controls.Enqueue(new TextBox());
            }
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
            while (_controls.TryDequeue(out _)) { }
            TestContext.WriteLine($@"{nameof(Teardown)} complete.");
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
        }

        [Test]
        public void SetEnabled_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(SetEnabled_DoesNotThrow)} start.");
            while (_controls.TryDequeue(out Control control))
            {
                foreach (var value in EnumValues.GetBool())
                {
                    Assert.DoesNotThrow(() => InvokeControl.SetEnabled(control, value));
                    Assert.DoesNotThrowAsync(async () => await Task.Run(() => InvokeControl.SetEnabled(control, value)));
                }
            }
            TestContext.WriteLine($@"{nameof(SetEnabled_DoesNotThrow)} complete.");
        }

        [Test]
        public void SetText_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(SetText_DoesNotThrow)} start.");
            while (_controls.TryDequeue(out Control control))
            {
                foreach (var value in EnumValues.GetString())
                {
                    Assert.DoesNotThrow(() => InvokeControl.SetText(control, value));
                    Assert.DoesNotThrowAsync(async () => await Task.Run(() => InvokeControl.SetText(control, value)));
                }
            }
            TestContext.WriteLine($@"{nameof(SetText_DoesNotThrow)} complete.");
        }

        [Test]
        public void AddText_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(AddText_DoesNotThrow)} start.");
            while (_controls.TryDequeue(out Control control))
            {
                foreach (var value in EnumValues.GetString())
                {
                    Assert.DoesNotThrow(() => InvokeControl.AddText(control, value));
                    Assert.DoesNotThrowAsync(async () => await Task.Run(() => InvokeControl.AddText(control, value)));
                }
            }
            TestContext.WriteLine($@"{nameof(AddText_DoesNotThrow)} complete.");
        }

        [Test]
        public void SetVisible_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(SetVisible_DoesNotThrow)} start.");
            while (_controls.TryDequeue(out Control control))
            {
                foreach (var value in EnumValues.GetBool())
                {
                    Assert.DoesNotThrow(() => InvokeControl.SetVisible(control, value));
                    Assert.DoesNotThrowAsync(async () => await Task.Run(() => InvokeControl.SetVisible(control, value)));
                }
            }
            TestContext.WriteLine($@"{nameof(SetVisible_DoesNotThrow)} complete.");
        }

        [Test]
        public void SetBackColor_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(SetBackColor_DoesNotThrow)} start.");
            while (_controls.TryDequeue(out Control control))
            {
                foreach (var value in EnumWinForm.GetColor())
                {
                    Assert.DoesNotThrow(() => InvokeControl.SetBackColor(control, value));
                    Assert.DoesNotThrowAsync(async () => await Task.Run(() => InvokeControl.SetBackColor(control, value)));
                }
            }
            TestContext.WriteLine($@"{nameof(SetBackColor_DoesNotThrow)} complete.");
        }

        [Test]
        public void SetForeColor_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(SetForeColor_DoesNotThrow)} start.");
            while (_controls.TryDequeue(out Control control))
            {
                foreach (var value in EnumWinForm.GetColor())
                {
                    Assert.DoesNotThrow(() => InvokeControl.SetForeColor(control, value));
                    Assert.DoesNotThrowAsync(async () => await Task.Run(() => InvokeControl.SetForeColor(control, value)));
                }
            }
            TestContext.WriteLine($@"{nameof(SetForeColor_DoesNotThrow)} complete.");
        }

        [Test]
        public void Focus_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Focus_DoesNotThrow)} start.");
            while (_controls.TryDequeue(out Control control))
            {
                Assert.DoesNotThrow(() => InvokeControl.Focus(control));
                Assert.DoesNotThrowAsync(async () => await Task.Run(() => InvokeControl.Focus(control)));
            }
            TestContext.WriteLine($@"{nameof(Focus_DoesNotThrow)} complete.");
        }

        [Test]
        public void Select_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Select_DoesNotThrow)} start.");
            while (_controls.TryDequeue(out Control control))
            {
                Assert.DoesNotThrow(() => InvokeControl.Select(control));
                Assert.DoesNotThrowAsync(async () => await Task.Run(() => InvokeControl.Select(control)));
            }
            TestContext.WriteLine($@"{nameof(Select_DoesNotThrow)} complete.");
        }
    }
}
