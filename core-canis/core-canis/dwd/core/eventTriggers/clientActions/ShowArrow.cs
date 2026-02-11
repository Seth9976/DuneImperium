using System;
using Canis.utils.ids;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Networking.eventtriggers.clientactions;

namespace dwd.core.eventTriggers.clientActions
{
	// Token: 0x020001B5 RID: 437
	public sealed class ShowArrow : ClientAction
	{
		// Token: 0x06001875 RID: 6261 RVA: 0x000757C8 File Offset: 0x000739C8
		// Note: this type is marked as 'beforefieldinit'.
		static ShowArrow()
		{
			Il2CppClassPointerStore<ShowArrow>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.eventTriggers.clientActions", "ShowArrow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowArrow>.NativeClassPtr);
			ShowArrow.NativeFieldInfoPtr_entityIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowArrow>.NativeClassPtr, "entityIDs");
			ShowArrow.NativeFieldInfoPtr_EntityIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowArrow>.NativeClassPtr, "EntityIDs");
			ShowArrow.NativeFieldInfoPtr_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowArrow>.NativeClassPtr, "Handle");
			ShowArrow.NativeFieldInfoPtr_AdditionalParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowArrow>.NativeClassPtr, "AdditionalParams");
			ShowArrow.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowArrow>.NativeClassPtr, "Label");
			ShowArrow.NativeFieldInfoPtr_WaitMilliseconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowArrow>.NativeClassPtr, "WaitMilliseconds");
			ShowArrow.NativeFieldInfoPtr_Kwargs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowArrow>.NativeClassPtr, "Kwargs");
			ShowArrow.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_EntityID_ArrowID_String_LocalizableText_Int64_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowArrow>.NativeClassPtr, 100667209);
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x00075898 File Offset: 0x00073A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880524, XrefRangeEnd = 880543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShowArrow(Il2CppReferenceArray<EntityID> entityIDs, ArrowID handle, string additionalParams, LocalizableText label, long waitMilliseconds, Dictionary<string, string> kwargs)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowArrow>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityIDs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(additionalParams);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(label);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref waitMilliseconds;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(kwargs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowArrow.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_EntityID_ArrowID_String_LocalizableText_Int64_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x0000ABE4 File Offset: 0x00008DE4
		public ShowArrow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06001878 RID: 6264 RVA: 0x0007593C File Offset: 0x00073B3C
		// (set) Token: 0x06001879 RID: 6265 RVA: 0x0000ABED File Offset: 0x00008DED
		public unsafe Il2CppReferenceArray<EntityID> entityIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowArrow.NativeFieldInfoPtr_entityIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowArrow.NativeFieldInfoPtr_entityIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x0600187A RID: 6266 RVA: 0x0007596C File Offset: 0x00073B6C
		// (set) Token: 0x0600187B RID: 6267 RVA: 0x0000AC0C File Offset: 0x00008E0C
		public unsafe ReadOnlyCollection<EntityID> EntityIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowArrow.NativeFieldInfoPtr_EntityIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowArrow.NativeFieldInfoPtr_EntityIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x0600187C RID: 6268 RVA: 0x0007599C File Offset: 0x00073B9C
		// (set) Token: 0x0600187D RID: 6269 RVA: 0x0000AC2B File Offset: 0x00008E2B
		public unsafe ArrowID Handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowArrow.NativeFieldInfoPtr_Handle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrowID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowArrow.NativeFieldInfoPtr_Handle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x0600187E RID: 6270 RVA: 0x000759CC File Offset: 0x00073BCC
		// (set) Token: 0x0600187F RID: 6271 RVA: 0x0000AC4A File Offset: 0x00008E4A
		public unsafe string AdditionalParams
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowArrow.NativeFieldInfoPtr_AdditionalParams);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowArrow.NativeFieldInfoPtr_AdditionalParams), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06001880 RID: 6272 RVA: 0x000759F4 File Offset: 0x00073BF4
		// (set) Token: 0x06001881 RID: 6273 RVA: 0x0000AC69 File Offset: 0x00008E69
		public unsafe LocalizableText Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowArrow.NativeFieldInfoPtr_Label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizableText>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowArrow.NativeFieldInfoPtr_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06001882 RID: 6274 RVA: 0x00075A24 File Offset: 0x00073C24
		// (set) Token: 0x06001883 RID: 6275 RVA: 0x0000AC88 File Offset: 0x00008E88
		public unsafe long WaitMilliseconds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowArrow.NativeFieldInfoPtr_WaitMilliseconds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowArrow.NativeFieldInfoPtr_WaitMilliseconds)) = value;
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06001884 RID: 6276 RVA: 0x00075A4C File Offset: 0x00073C4C
		// (set) Token: 0x06001885 RID: 6277 RVA: 0x0000ACA3 File Offset: 0x00008EA3
		public unsafe Dictionary<string, string> Kwargs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowArrow.NativeFieldInfoPtr_Kwargs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowArrow.NativeFieldInfoPtr_Kwargs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001145 RID: 4421
		private static readonly IntPtr NativeFieldInfoPtr_entityIDs;

		// Token: 0x04001146 RID: 4422
		private static readonly IntPtr NativeFieldInfoPtr_EntityIDs;

		// Token: 0x04001147 RID: 4423
		private static readonly IntPtr NativeFieldInfoPtr_Handle;

		// Token: 0x04001148 RID: 4424
		private static readonly IntPtr NativeFieldInfoPtr_AdditionalParams;

		// Token: 0x04001149 RID: 4425
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x0400114A RID: 4426
		private static readonly IntPtr NativeFieldInfoPtr_WaitMilliseconds;

		// Token: 0x0400114B RID: 4427
		private static readonly IntPtr NativeFieldInfoPtr_Kwargs;

		// Token: 0x0400114C RID: 4428
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_EntityID_ArrowID_String_LocalizableText_Int64_Dictionary_2_String_String_0;
	}
}
