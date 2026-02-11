using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Networking.selection.targetinformation
{
	// Token: 0x0200007C RID: 124
	public class XTargetInformation : TargetInformation
	{
		// Token: 0x06000420 RID: 1056 RVA: 0x00010F40 File Offset: 0x0000F140
		// Note: this type is marked as 'beforefieldinit'.
		static XTargetInformation()
		{
			Il2CppClassPointerStore<XTargetInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.targetinformation", "XTargetInformation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XTargetInformation>.NativeClassPtr);
			XTargetInformation.NativeFieldInfoPtr_Forced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XTargetInformation>.NativeClassPtr, "Forced");
			XTargetInformation.NativeFieldInfoPtr_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XTargetInformation>.NativeClassPtr, "Min");
			XTargetInformation.NativeFieldInfoPtr_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XTargetInformation>.NativeClassPtr, "Max");
			XTargetInformation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XTargetInformation>.NativeClassPtr, 100663562);
			XTargetInformation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XTargetInformation>.NativeClassPtr, 100663563);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00010FD4 File Offset: 0x0000F1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194491, XrefRangeEnd = 1194499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XTargetInformation.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00011018 File Offset: 0x0000F218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194499, XrefRangeEnd = 1194500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XTargetInformation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XTargetInformation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XTargetInformation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x000048A7 File Offset: 0x00002AA7
		public XTargetInformation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x00011054 File Offset: 0x0000F254
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x000048B0 File Offset: 0x00002AB0
		public unsafe bool Forced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XTargetInformation.NativeFieldInfoPtr_Forced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XTargetInformation.NativeFieldInfoPtr_Forced)) = value;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x0001107C File Offset: 0x0000F27C
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x000048CB File Offset: 0x00002ACB
		public unsafe int Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XTargetInformation.NativeFieldInfoPtr_Min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XTargetInformation.NativeFieldInfoPtr_Min)) = value;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x000110A4 File Offset: 0x0000F2A4
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x000048E6 File Offset: 0x00002AE6
		public unsafe int Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XTargetInformation.NativeFieldInfoPtr_Max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XTargetInformation.NativeFieldInfoPtr_Max)) = value;
			}
		}

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeFieldInfoPtr_Forced;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeFieldInfoPtr_Min;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeFieldInfoPtr_Max;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
