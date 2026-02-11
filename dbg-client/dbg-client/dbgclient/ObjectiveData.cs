using System;
using Canis.tutorialScripts;
using Canis.utils.localization;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dbgclient
{
	// Token: 0x0200007E RID: 126
	public class ObjectiveData : NameLookup
	{
		// Token: 0x060004C8 RID: 1224 RVA: 0x0002C7BC File Offset: 0x0002A9BC
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectiveData()
		{
			Il2CppClassPointerStore<ObjectiveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient", "ObjectiveData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectiveData>.NativeClassPtr);
			ObjectiveData.NativeFieldInfoPtr_locKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveData>.NativeClassPtr, "locKey");
			ObjectiveData.NativeFieldInfoPtr_cachedDisplayString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveData>.NativeClassPtr, "cachedDisplayString");
			ObjectiveData.NativeFieldInfoPtr_currentProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveData>.NativeClassPtr, "currentProgress");
			ObjectiveData.NativeFieldInfoPtr_maxProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveData>.NativeClassPtr, "maxProgress");
			ObjectiveData.NativeFieldInfoPtr_complete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveData>.NativeClassPtr, "complete");
			ObjectiveData.NativeFieldInfoPtr__ObjectiveID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveData>.NativeClassPtr, "<ObjectiveID>k__BackingField");
			ObjectiveData.NativeMethodInfoPtr__ctor_Public_Void_Objective_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveData>.NativeClassPtr, 100664025);
			ObjectiveData.NativeMethodInfoPtr_get_ObjectiveID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveData>.NativeClassPtr, 100664026);
			ObjectiveData.NativeMethodInfoPtr_get_CurrentProgress_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveData>.NativeClassPtr, 100664027);
			ObjectiveData.NativeMethodInfoPtr_set_CurrentProgress_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveData>.NativeClassPtr, 100664028);
			ObjectiveData.NativeMethodInfoPtr_get_MaxProgress_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveData>.NativeClassPtr, 100664029);
			ObjectiveData.NativeMethodInfoPtr_set_MaxProgress_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveData>.NativeClassPtr, 100664030);
			ObjectiveData.NativeMethodInfoPtr_get_Complete_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveData>.NativeClassPtr, 100664031);
			ObjectiveData.NativeMethodInfoPtr_set_Complete_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveData>.NativeClassPtr, 100664032);
			ObjectiveData.NativeMethodInfoPtr_name_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveData>.NativeClassPtr, 100664033);
			ObjectiveData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveData>.NativeClassPtr, 100664034);
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x0002C92C File Offset: 0x0002AB2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 501092, RefRangeEnd = 501093, XrefRangeStart = 501073, XrefRangeEnd = 501092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectiveData(Objective objective, bool complete)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectiveData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objective);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref complete;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectiveData.NativeMethodInfoPtr__ctor_Public_Void_Objective_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x0002C988 File Offset: 0x0002AB88
		public unsafe int ObjectiveID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectiveData.NativeMethodInfoPtr_get_ObjectiveID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x0002C9C4 File Offset: 0x0002ABC4
		// (set) Token: 0x060004CC RID: 1228 RVA: 0x0002CA00 File Offset: 0x0002AC00
		public unsafe int CurrentProgress
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectiveData.NativeMethodInfoPtr_get_CurrentProgress_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 501107, RefRangeEnd = 501108, XrefRangeStart = 501093, XrefRangeEnd = 501107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectiveData.NativeMethodInfoPtr_set_CurrentProgress_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x0002CA40 File Offset: 0x0002AC40
		// (set) Token: 0x060004CE RID: 1230 RVA: 0x0002CA7C File Offset: 0x0002AC7C
		public unsafe int MaxProgress
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 134006, RefRangeEnd = 134007, XrefRangeStart = 134006, XrefRangeEnd = 134007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectiveData.NativeMethodInfoPtr_get_MaxProgress_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 501122, RefRangeEnd = 501123, XrefRangeStart = 501108, XrefRangeEnd = 501122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectiveData.NativeMethodInfoPtr_set_MaxProgress_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x0002CABC File Offset: 0x0002ACBC
		// (set) Token: 0x060004D0 RID: 1232 RVA: 0x0002CAF8 File Offset: 0x0002ACF8
		public unsafe bool Complete
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectiveData.NativeMethodInfoPtr_get_Complete_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501123, XrefRangeEnd = 501124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectiveData.NativeMethodInfoPtr_set_Complete_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x0002CB38 File Offset: 0x0002AD38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501124, XrefRangeEnd = 501126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string name()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectiveData.NativeMethodInfoPtr_name_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x0002CB7C File Offset: 0x0002AD7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501126, XrefRangeEnd = 501158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectiveData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x0000429A File Offset: 0x0000249A
		public ObjectiveData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x0002CBC0 File Offset: 0x0002ADC0
		// (set) Token: 0x060004D5 RID: 1237 RVA: 0x000042A3 File Offset: 0x000024A3
		public unsafe string locKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectiveData.NativeFieldInfoPtr_locKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectiveData.NativeFieldInfoPtr_locKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x0002CBE8 File Offset: 0x0002ADE8
		// (set) Token: 0x060004D7 RID: 1239 RVA: 0x000042C2 File Offset: 0x000024C2
		public unsafe LocalizedString cachedDisplayString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectiveData.NativeFieldInfoPtr_cachedDisplayString);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectiveData.NativeFieldInfoPtr_cachedDisplayString), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x0002CC18 File Offset: 0x0002AE18
		// (set) Token: 0x060004D9 RID: 1241 RVA: 0x000042E1 File Offset: 0x000024E1
		public unsafe int currentProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectiveData.NativeFieldInfoPtr_currentProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectiveData.NativeFieldInfoPtr_currentProgress)) = value;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x0002CC40 File Offset: 0x0002AE40
		// (set) Token: 0x060004DB RID: 1243 RVA: 0x000042FC File Offset: 0x000024FC
		public unsafe int maxProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectiveData.NativeFieldInfoPtr_maxProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectiveData.NativeFieldInfoPtr_maxProgress)) = value;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x0002CC68 File Offset: 0x0002AE68
		// (set) Token: 0x060004DD RID: 1245 RVA: 0x00004317 File Offset: 0x00002517
		public unsafe bool complete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectiveData.NativeFieldInfoPtr_complete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectiveData.NativeFieldInfoPtr_complete)) = value;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x0002CC90 File Offset: 0x0002AE90
		// (set) Token: 0x060004DF RID: 1247 RVA: 0x00004332 File Offset: 0x00002532
		public unsafe int _ObjectiveID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectiveData.NativeFieldInfoPtr__ObjectiveID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectiveData.NativeFieldInfoPtr__ObjectiveID_k__BackingField)) = value;
			}
		}

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeFieldInfoPtr_locKey;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeFieldInfoPtr_cachedDisplayString;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeFieldInfoPtr_currentProgress;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeFieldInfoPtr_maxProgress;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeFieldInfoPtr_complete;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeFieldInfoPtr__ObjectiveID_k__BackingField;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Objective_Boolean_0;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectiveID_Public_get_Int32_0;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentProgress_Public_get_Int32_0;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentProgress_Public_set_Void_Int32_0;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxProgress_Public_get_Int32_0;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxProgress_Public_set_Void_Int32_0;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeMethodInfoPtr_get_Complete_Public_get_Boolean_0;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeMethodInfoPtr_set_Complete_Public_set_Void_Boolean_0;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeMethodInfoPtr_name_Protected_Virtual_String_0;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
