using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Yoga
{
	// Token: 0x02000008 RID: 8
	public static class YogaConstants : Object
	{
		// Token: 0x0600002E RID: 46 RVA: 0x000021A1 File Offset: 0x000003A1
		// Note: this type is marked as 'beforefieldinit'.
		static YogaConstants()
		{
			Il2CppClassPointerStore<YogaConstants>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.Yoga", "YogaConstants");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YogaConstants>.NativeClassPtr);
			YogaConstants.NativeMethodInfoPtr_IsUndefined_Public_Static_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YogaConstants>.NativeClassPtr, 100663312);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0001D208 File Offset: 0x0001B408
		[CallerCount(0)]
		public unsafe static bool IsUndefined(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YogaConstants.NativeMethodInfoPtr_IsUndefined_Public_Static_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000021DA File Offset: 0x000003DA
		public YogaConstants(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0001D248 File Offset: 0x0001B448
		public static bool IsUndefined(YogaValue value)
		{
			return value.Unit == YogaUnit.Undefined;
		}

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_IsUndefined_Public_Static_Boolean_Single_0;

		// Token: 0x0400001B RID: 27
		public const float Undefined = float.NaN;
	}
}
