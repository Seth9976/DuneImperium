using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000167 RID: 359
	[StructLayout(2)]
	public struct SafeHandleAccess
	{
		// Token: 0x06001A71 RID: 6769 RVA: 0x0007A8F8 File Offset: 0x00078AF8
		// Note: this type is marked as 'beforefieldinit'.
		static SafeHandleAccess()
		{
			Il2CppClassPointerStore<SafeHandleAccess>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "SafeHandleAccess");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeHandleAccess>.NativeClassPtr);
			SafeHandleAccess.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeHandleAccess>.NativeClassPtr, "m_Handle");
			SafeHandleAccess.NativeMethodInfoPtr_IsNull_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandleAccess>.NativeClassPtr, 100667159);
			SafeHandleAccess.NativeMethodInfoPtr_op_Implicit_Public_Static_IntPtr_SafeHandleAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandleAccess>.NativeClassPtr, 100667160);
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x0007A964 File Offset: 0x00078B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322081, XrefRangeEnd = 322082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNull()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandleAccess.NativeMethodInfoPtr_IsNull_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x0007A994 File Offset: 0x00078B94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 322083, RefRangeEnd = 322085, XrefRangeStart = 322082, XrefRangeEnd = 322083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator IntPtr(SafeHandleAccess a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeHandleAccess.NativeMethodInfoPtr_op_Implicit_Public_Static_IntPtr_SafeHandleAccess_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x0000C03D File Offset: 0x0000A23D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SafeHandleAccess>.NativeClassPtr, ref this));
		}

		// Token: 0x0400124A RID: 4682
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x0400124B RID: 4683
		private static readonly IntPtr NativeMethodInfoPtr_IsNull_Public_Boolean_0;

		// Token: 0x0400124C RID: 4684
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_IntPtr_SafeHandleAccess_0;

		// Token: 0x0400124D RID: 4685
		[FieldOffset(0)]
		public IntPtr m_Handle;
	}
}
