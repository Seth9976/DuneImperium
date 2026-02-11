using System;

namespace UnityEngine.Assertions.Must
{
	// Token: 0x02000374 RID: 884
	public static class MustExtensions
	{
		// Token: 0x06002F9C RID: 12188 RVA: 0x00013477 File Offset: 0x00011677
		public static void MustBeTrue(bool value)
		{
			Assert.IsTrue(value);
		}

		// Token: 0x06002F9D RID: 12189 RVA: 0x00013481 File Offset: 0x00011681
		public static void MustBeTrue(bool value, string message)
		{
			Assert.IsTrue(value, message);
		}

		// Token: 0x06002F9E RID: 12190 RVA: 0x0001348C File Offset: 0x0001168C
		public static void MustBeFalse(bool value)
		{
			Assert.IsFalse(value);
		}

		// Token: 0x06002F9F RID: 12191 RVA: 0x00013496 File Offset: 0x00011696
		public static void MustBeFalse(bool value, string message)
		{
			Assert.IsFalse(value, message);
		}

		// Token: 0x06002FA0 RID: 12192 RVA: 0x000134A1 File Offset: 0x000116A1
		public static void MustBeApproximatelyEqual(float actual, float expected)
		{
			Assert.AreApproximatelyEqual(actual, expected);
		}

		// Token: 0x06002FA1 RID: 12193 RVA: 0x000134AC File Offset: 0x000116AC
		public static void MustBeApproximatelyEqual(float actual, float expected, string message)
		{
			Assert.AreApproximatelyEqual(actual, expected, message);
		}

		// Token: 0x06002FA2 RID: 12194 RVA: 0x000134B8 File Offset: 0x000116B8
		public static void MustBeApproximatelyEqual(float actual, float expected, float tolerance)
		{
			Assert.AreApproximatelyEqual(actual, expected, tolerance);
		}

		// Token: 0x06002FA3 RID: 12195 RVA: 0x000134C4 File Offset: 0x000116C4
		public static void MustBeApproximatelyEqual(float actual, float expected, float tolerance, string message)
		{
			Assert.AreApproximatelyEqual(expected, actual, tolerance, message);
		}

		// Token: 0x06002FA4 RID: 12196 RVA: 0x000134D1 File Offset: 0x000116D1
		public static void MustNotBeApproximatelyEqual(float actual, float expected)
		{
			Assert.AreNotApproximatelyEqual(expected, actual);
		}

		// Token: 0x06002FA5 RID: 12197 RVA: 0x000134DC File Offset: 0x000116DC
		public static void MustNotBeApproximatelyEqual(float actual, float expected, string message)
		{
			Assert.AreNotApproximatelyEqual(expected, actual, message);
		}

		// Token: 0x06002FA6 RID: 12198 RVA: 0x000134E8 File Offset: 0x000116E8
		public static void MustNotBeApproximatelyEqual(float actual, float expected, float tolerance)
		{
			Assert.AreNotApproximatelyEqual(expected, actual, tolerance);
		}

		// Token: 0x06002FA7 RID: 12199 RVA: 0x000134F4 File Offset: 0x000116F4
		public static void MustNotBeApproximatelyEqual(float actual, float expected, float tolerance, string message)
		{
			Assert.AreNotApproximatelyEqual(expected, actual, tolerance, message);
		}

		// Token: 0x06002FA8 RID: 12200 RVA: 0x00013501 File Offset: 0x00011701
		public static void MustBeEqual<T>(T actual, T expected)
		{
			Assert.AreEqual<T>(actual, expected);
		}

		// Token: 0x06002FA9 RID: 12201 RVA: 0x0001350C File Offset: 0x0001170C
		public static void MustBeEqual<T>(T actual, T expected, string message)
		{
			Assert.AreEqual<T>(expected, actual, message);
		}

		// Token: 0x06002FAA RID: 12202 RVA: 0x00013518 File Offset: 0x00011718
		public static void MustNotBeEqual<T>(T actual, T expected)
		{
			Assert.AreNotEqual<T>(actual, expected);
		}

		// Token: 0x06002FAB RID: 12203 RVA: 0x00013523 File Offset: 0x00011723
		public static void MustNotBeEqual<T>(T actual, T expected, string message)
		{
			Assert.AreNotEqual<T>(expected, actual, message);
		}

		// Token: 0x06002FAC RID: 12204 RVA: 0x0001352F File Offset: 0x0001172F
		public static void MustBeNull<T>(T expected) where T : class
		{
			Assert.IsNull<T>(expected);
		}

		// Token: 0x06002FAD RID: 12205 RVA: 0x00013539 File Offset: 0x00011739
		public static void MustBeNull<T>(T expected, string message) where T : class
		{
			Assert.IsNull<T>(expected, message);
		}

		// Token: 0x06002FAE RID: 12206 RVA: 0x00013544 File Offset: 0x00011744
		public static void MustNotBeNull<T>(T expected) where T : class
		{
			Assert.IsNotNull<T>(expected);
		}

		// Token: 0x06002FAF RID: 12207 RVA: 0x0001354E File Offset: 0x0001174E
		public static void MustNotBeNull<T>(T expected, string message) where T : class
		{
			Assert.IsNotNull<T>(expected, message);
		}
	}
}
