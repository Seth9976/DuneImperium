using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.ConstrainedExecution
{
	// Token: 0x020003A6 RID: 934
	public sealed class PrePrepareMethodAttribute : Attribute
	{
		// Token: 0x060038B0 RID: 14512 RVA: 0x00014CB1 File Offset: 0x00012EB1
		// Note: this type is marked as 'beforefieldinit'.
		static PrePrepareMethodAttribute()
		{
			Il2CppClassPointerStore<PrePrepareMethodAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.ConstrainedExecution", "PrePrepareMethodAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrePrepareMethodAttribute>.NativeClassPtr);
			PrePrepareMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrePrepareMethodAttribute>.NativeClassPtr, 100671771);
		}

		// Token: 0x060038B1 RID: 14513 RVA: 0x00113C0C File Offset: 0x00111E0C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrePrepareMethodAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrePrepareMethodAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrePrepareMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060038B2 RID: 14514 RVA: 0x00014CEA File Offset: 0x00012EEA
		public PrePrepareMethodAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002E4E RID: 11854
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
