using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x02000106 RID: 262
	public static class ScriptingRuntimeHelpers : Object
	{
		// Token: 0x06000FCA RID: 4042 RVA: 0x00053284 File Offset: 0x00051484
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptingRuntimeHelpers()
		{
			Il2CppClassPointerStore<ScriptingRuntimeHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "ScriptingRuntimeHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptingRuntimeHelpers>.NativeClassPtr);
			ScriptingRuntimeHelpers.NativeMethodInfoPtr_Int32ToObject_Public_Static_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptingRuntimeHelpers>.NativeClassPtr, 100666237);
			ScriptingRuntimeHelpers.NativeMethodInfoPtr_GetPrimitiveDefaultValue_Internal_Static_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptingRuntimeHelpers>.NativeClassPtr, 100666238);
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x000532DC File Offset: 0x000514DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1026912, RefRangeEnd = 1026914, XrefRangeStart = 1026908, XrefRangeEnd = 1026912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Int32ToObject(int i)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptingRuntimeHelpers.NativeMethodInfoPtr_Int32ToObject_Public_Static_Object_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x0005331C File Offset: 0x0005151C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1026962, RefRangeEnd = 1026966, XrefRangeStart = 1026914, XrefRangeEnd = 1026962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetPrimitiveDefaultValue(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptingRuntimeHelpers.NativeMethodInfoPtr_GetPrimitiveDefaultValue_Internal_Static_Object_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x00006ED7 File Offset: 0x000050D7
		public ScriptingRuntimeHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B58 RID: 2904
		private static readonly IntPtr NativeMethodInfoPtr_Int32ToObject_Public_Static_Object_Int32_0;

		// Token: 0x04000B59 RID: 2905
		private static readonly IntPtr NativeMethodInfoPtr_GetPrimitiveDefaultValue_Internal_Static_Object_Type_0;
	}
}
