using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200014C RID: 332
	public class ScriptingUtility : Object
	{
		// Token: 0x0600191F RID: 6431 RVA: 0x00009CC6 File Offset: 0x00007EC6
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptingUtility()
		{
			Il2CppClassPointerStore<ScriptingUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ScriptingUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptingUtility>.NativeClassPtr);
			ScriptingUtility.NativeMethodInfoPtr_IsManagedCodeWorking_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptingUtility>.NativeClassPtr, 100666758);
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x00076050 File Offset: 0x00074250
		[CallerCount(0)]
		public unsafe static bool IsManagedCodeWorking()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptingUtility.NativeMethodInfoPtr_IsManagedCodeWorking_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x00009CFF File Offset: 0x00007EFF
		public ScriptingUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001667 RID: 5735
		private static readonly IntPtr NativeMethodInfoPtr_IsManagedCodeWorking_Private_Static_Boolean_0;

		// Token: 0x0200075B RID: 1883
		[StructLayout(2)]
		public struct TestClass
		{
			// Token: 0x06003775 RID: 14197 RVA: 0x00013F37 File Offset: 0x00012137
			// Note: this type is marked as 'beforefieldinit'.
			static TestClass()
			{
				Il2CppClassPointerStore<ScriptingUtility.TestClass>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptingUtility>.NativeClassPtr, "TestClass");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptingUtility.TestClass>.NativeClassPtr);
				ScriptingUtility.TestClass.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptingUtility.TestClass>.NativeClassPtr, "value");
			}

			// Token: 0x06003776 RID: 14198 RVA: 0x00013F6B File Offset: 0x0001216B
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptingUtility.TestClass>.NativeClassPtr, ref this));
			}

			// Token: 0x04002C70 RID: 11376
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04002C71 RID: 11377
			[FieldOffset(0)]
			public int value;
		}
	}
}
