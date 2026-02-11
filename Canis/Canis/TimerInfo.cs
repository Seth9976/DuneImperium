using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Networking.selection.messages;

namespace Canis
{
	// Token: 0x02000026 RID: 38
	public class TimerInfo : Object
	{
		// Token: 0x0600026F RID: 623 RVA: 0x00023BC4 File Offset: 0x00021DC4
		// Note: this type is marked as 'beforefieldinit'.
		static TimerInfo()
		{
			Il2CppClassPointerStore<TimerInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis", "TimerInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimerInfo>.NativeClassPtr);
			TimerInfo.NativeFieldInfoPtr_TimerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerInfo>.NativeClassPtr, "TimerID");
			TimerInfo.NativeFieldInfoPtr_TimerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerInfo>.NativeClassPtr, "TimerType");
			TimerInfo.NativeFieldInfoPtr_ForAccounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerInfo>.NativeClassPtr, "ForAccounts");
			TimerInfo.NativeFieldInfoPtr_ForSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerInfo>.NativeClassPtr, "ForSelections");
			TimerInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerInfo>.NativeClassPtr, 100663901);
			TimerInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerInfo>.NativeClassPtr, 100663902);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00023C6C File Offset: 0x00021E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 548735, XrefRangeEnd = 548744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TimerInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00023CB0 File Offset: 0x00021EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 548744, XrefRangeEnd = 548749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimerInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00002F4B File Offset: 0x0000114B
		public TimerInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000273 RID: 627 RVA: 0x00023CEC File Offset: 0x00021EEC
		// (set) Token: 0x06000274 RID: 628 RVA: 0x00002F54 File Offset: 0x00001154
		public unsafe TimerID TimerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerInfo.NativeFieldInfoPtr_TimerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerInfo.NativeFieldInfoPtr_TimerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000275 RID: 629 RVA: 0x00023D1C File Offset: 0x00021F1C
		// (set) Token: 0x06000276 RID: 630 RVA: 0x00002F73 File Offset: 0x00001173
		public unsafe string TimerType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerInfo.NativeFieldInfoPtr_TimerType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerInfo.NativeFieldInfoPtr_TimerType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000277 RID: 631 RVA: 0x00023D44 File Offset: 0x00021F44
		// (set) Token: 0x06000278 RID: 632 RVA: 0x00002F92 File Offset: 0x00001192
		public unsafe Il2CppReferenceArray<AccountID> ForAccounts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerInfo.NativeFieldInfoPtr_ForAccounts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AccountID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerInfo.NativeFieldInfoPtr_ForAccounts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000279 RID: 633 RVA: 0x00023D74 File Offset: 0x00021F74
		// (set) Token: 0x0600027A RID: 634 RVA: 0x00002FB1 File Offset: 0x000011B1
		public unsafe Il2CppReferenceArray<SelectionMessage> ForSelections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerInfo.NativeFieldInfoPtr_ForSelections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SelectionMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerInfo.NativeFieldInfoPtr_ForSelections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeFieldInfoPtr_TimerID;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeFieldInfoPtr_TimerType;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeFieldInfoPtr_ForAccounts;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeFieldInfoPtr_ForSelections;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
