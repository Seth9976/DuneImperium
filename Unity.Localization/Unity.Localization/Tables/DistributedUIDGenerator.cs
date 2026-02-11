using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Localization.Tables
{
	// Token: 0x02000025 RID: 37
	[Serializable]
	public class DistributedUIDGenerator : Object
	{
		// Token: 0x0600020E RID: 526 RVA: 0x0001144C File Offset: 0x0000F64C
		// Note: this type is marked as 'beforefieldinit'.
		static DistributedUIDGenerator()
		{
			Il2CppClassPointerStore<DistributedUIDGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Tables", "DistributedUIDGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DistributedUIDGenerator>.NativeClassPtr);
			DistributedUIDGenerator.NativeFieldInfoPtr_kMachineIdBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributedUIDGenerator>.NativeClassPtr, "kMachineIdBits");
			DistributedUIDGenerator.NativeFieldInfoPtr_kSequenceBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributedUIDGenerator>.NativeClassPtr, "kSequenceBits");
			DistributedUIDGenerator.NativeFieldInfoPtr_kMaxNodeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributedUIDGenerator>.NativeClassPtr, "kMaxNodeId");
			DistributedUIDGenerator.NativeFieldInfoPtr_kMaxSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributedUIDGenerator>.NativeClassPtr, "kMaxSequence");
			DistributedUIDGenerator.NativeFieldInfoPtr_MachineIdPrefKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributedUIDGenerator>.NativeClassPtr, "MachineIdPrefKey");
			DistributedUIDGenerator.NativeFieldInfoPtr_m_CustomEpoch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributedUIDGenerator>.NativeClassPtr, "m_CustomEpoch");
			DistributedUIDGenerator.NativeFieldInfoPtr_m_LastTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributedUIDGenerator>.NativeClassPtr, "m_LastTimestamp");
			DistributedUIDGenerator.NativeFieldInfoPtr_m_Sequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributedUIDGenerator>.NativeClassPtr, "m_Sequence");
			DistributedUIDGenerator.NativeFieldInfoPtr_m_MachineId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DistributedUIDGenerator>.NativeClassPtr, "m_MachineId");
			DistributedUIDGenerator.NativeMethodInfoPtr_get_CustomEpoch_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributedUIDGenerator>.NativeClassPtr, 100663686);
			DistributedUIDGenerator.NativeMethodInfoPtr_get_MachineId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributedUIDGenerator>.NativeClassPtr, 100663687);
			DistributedUIDGenerator.NativeMethodInfoPtr_set_MachineId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributedUIDGenerator>.NativeClassPtr, 100663688);
			DistributedUIDGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributedUIDGenerator>.NativeClassPtr, 100663689);
			DistributedUIDGenerator.NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributedUIDGenerator>.NativeClassPtr, 100663690);
			DistributedUIDGenerator.NativeMethodInfoPtr_GetNextKey_Public_Virtual_Final_New_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributedUIDGenerator>.NativeClassPtr, 100663691);
			DistributedUIDGenerator.NativeMethodInfoPtr_TimeStamp_Private_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributedUIDGenerator>.NativeClassPtr, 100663692);
			DistributedUIDGenerator.NativeMethodInfoPtr_GetMachineId_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributedUIDGenerator>.NativeClassPtr, 100663693);
			DistributedUIDGenerator.NativeMethodInfoPtr_WaitNextMillis_Private_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistributedUIDGenerator>.NativeClassPtr, 100663694);
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600020F RID: 527 RVA: 0x000115E4 File Offset: 0x0000F7E4
		public unsafe long CustomEpoch
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributedUIDGenerator.NativeMethodInfoPtr_get_CustomEpoch_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00011620 File Offset: 0x0000F820
		// (set) Token: 0x06000211 RID: 529 RVA: 0x0001165C File Offset: 0x0000F85C
		public unsafe int MachineId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067206, XrefRangeEnd = 1067214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributedUIDGenerator.NativeMethodInfoPtr_get_MachineId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067214, XrefRangeEnd = 1067218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributedUIDGenerator.NativeMethodInfoPtr_set_MachineId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0001169C File Offset: 0x0000F89C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067218, XrefRangeEnd = 1067224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DistributedUIDGenerator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DistributedUIDGenerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributedUIDGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x000116D8 File Offset: 0x0000F8D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067224, XrefRangeEnd = 1067230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DistributedUIDGenerator(long customEpoch)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DistributedUIDGenerator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref customEpoch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributedUIDGenerator.NativeMethodInfoPtr__ctor_Public_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00011720 File Offset: 0x0000F920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067230, XrefRangeEnd = 1067254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual long GetNextKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributedUIDGenerator.NativeMethodInfoPtr_GetNextKey_Public_Virtual_Final_New_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0001175C File Offset: 0x0000F95C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067254, XrefRangeEnd = 1067259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long TimeStamp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributedUIDGenerator.NativeMethodInfoPtr_TimeStamp_Private_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00011798 File Offset: 0x0000F998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067259, XrefRangeEnd = 1067264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetMachineId()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributedUIDGenerator.NativeMethodInfoPtr_GetMachineId_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x000117C8 File Offset: 0x0000F9C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067264, XrefRangeEnd = 1067270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long WaitNextMillis(long currentTimestamp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref currentTimestamp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DistributedUIDGenerator.NativeMethodInfoPtr_WaitNextMillis_Private_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002C0B File Offset: 0x00000E0B
		public DistributedUIDGenerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000219 RID: 537 RVA: 0x00011814 File Offset: 0x0000FA14
		// (set) Token: 0x0600021A RID: 538 RVA: 0x00002C14 File Offset: 0x00000E14
		public unsafe static int kMachineIdBits
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DistributedUIDGenerator.NativeFieldInfoPtr_kMachineIdBits, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DistributedUIDGenerator.NativeFieldInfoPtr_kMachineIdBits, (void*)(&value));
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00011830 File Offset: 0x0000FA30
		// (set) Token: 0x0600021C RID: 540 RVA: 0x00002C22 File Offset: 0x00000E22
		public unsafe static int kSequenceBits
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DistributedUIDGenerator.NativeFieldInfoPtr_kSequenceBits, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DistributedUIDGenerator.NativeFieldInfoPtr_kSequenceBits, (void*)(&value));
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0001184C File Offset: 0x0000FA4C
		// (set) Token: 0x0600021E RID: 542 RVA: 0x00002C30 File Offset: 0x00000E30
		public unsafe static int kMaxNodeId
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DistributedUIDGenerator.NativeFieldInfoPtr_kMaxNodeId, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DistributedUIDGenerator.NativeFieldInfoPtr_kMaxNodeId, (void*)(&value));
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00011868 File Offset: 0x0000FA68
		// (set) Token: 0x06000220 RID: 544 RVA: 0x00002C3E File Offset: 0x00000E3E
		public unsafe static int kMaxSequence
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DistributedUIDGenerator.NativeFieldInfoPtr_kMaxSequence, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DistributedUIDGenerator.NativeFieldInfoPtr_kMaxSequence, (void*)(&value));
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000221 RID: 545 RVA: 0x00011884 File Offset: 0x0000FA84
		// (set) Token: 0x06000222 RID: 546 RVA: 0x00002C4C File Offset: 0x00000E4C
		public unsafe static string MachineIdPrefKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DistributedUIDGenerator.NativeFieldInfoPtr_MachineIdPrefKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DistributedUIDGenerator.NativeFieldInfoPtr_MachineIdPrefKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000223 RID: 547 RVA: 0x000118A4 File Offset: 0x0000FAA4
		// (set) Token: 0x06000224 RID: 548 RVA: 0x00002C5E File Offset: 0x00000E5E
		public unsafe long m_CustomEpoch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributedUIDGenerator.NativeFieldInfoPtr_m_CustomEpoch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributedUIDGenerator.NativeFieldInfoPtr_m_CustomEpoch)) = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000225 RID: 549 RVA: 0x000118CC File Offset: 0x0000FACC
		// (set) Token: 0x06000226 RID: 550 RVA: 0x00002C79 File Offset: 0x00000E79
		public unsafe long m_LastTimestamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributedUIDGenerator.NativeFieldInfoPtr_m_LastTimestamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributedUIDGenerator.NativeFieldInfoPtr_m_LastTimestamp)) = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000227 RID: 551 RVA: 0x000118F4 File Offset: 0x0000FAF4
		// (set) Token: 0x06000228 RID: 552 RVA: 0x00002C94 File Offset: 0x00000E94
		public unsafe long m_Sequence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributedUIDGenerator.NativeFieldInfoPtr_m_Sequence);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributedUIDGenerator.NativeFieldInfoPtr_m_Sequence)) = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000229 RID: 553 RVA: 0x0001191C File Offset: 0x0000FB1C
		// (set) Token: 0x0600022A RID: 554 RVA: 0x00002CAF File Offset: 0x00000EAF
		public unsafe int m_MachineId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributedUIDGenerator.NativeFieldInfoPtr_m_MachineId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DistributedUIDGenerator.NativeFieldInfoPtr_m_MachineId)) = value;
			}
		}

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeFieldInfoPtr_kMachineIdBits;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeFieldInfoPtr_kSequenceBits;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeFieldInfoPtr_kMaxNodeId;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeFieldInfoPtr_kMaxSequence;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeFieldInfoPtr_MachineIdPrefKey;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeFieldInfoPtr_m_CustomEpoch;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeFieldInfoPtr_m_LastTimestamp;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeFieldInfoPtr_m_Sequence;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeFieldInfoPtr_m_MachineId;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr_get_CustomEpoch_Public_get_Int64_0;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr_get_MachineId_Public_get_Int32_0;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr_set_MachineId_Public_set_Void_Int32_0;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr_GetNextKey_Public_Virtual_Final_New_Int64_0;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_TimeStamp_Private_Int64_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr_GetMachineId_Private_Static_Int32_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr_WaitNextMillis_Private_Int64_Int64_0;
	}
}
