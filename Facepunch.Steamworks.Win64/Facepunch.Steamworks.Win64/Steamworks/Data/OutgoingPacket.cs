using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x02000206 RID: 518
	public sealed class OutgoingPacket : ValueType
	{
		// Token: 0x060019EF RID: 6639 RVA: 0x0007D224 File Offset: 0x0007B424
		// Note: this type is marked as 'beforefieldinit'.
		static OutgoingPacket()
		{
			Il2CppClassPointerStore<OutgoingPacket>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "OutgoingPacket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutgoingPacket>.NativeClassPtr);
			OutgoingPacket.NativeFieldInfoPtr__Address_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutgoingPacket>.NativeClassPtr, "<Address>k__BackingField");
			OutgoingPacket.NativeFieldInfoPtr__Port_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutgoingPacket>.NativeClassPtr, "<Port>k__BackingField");
			OutgoingPacket.NativeFieldInfoPtr__Data_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutgoingPacket>.NativeClassPtr, "<Data>k__BackingField");
			OutgoingPacket.NativeFieldInfoPtr__Size_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutgoingPacket>.NativeClassPtr, "<Size>k__BackingField");
			OutgoingPacket.NativeMethodInfoPtr_get_Address_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutgoingPacket>.NativeClassPtr, 100668038);
			OutgoingPacket.NativeMethodInfoPtr_set_Address_Internal_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutgoingPacket>.NativeClassPtr, 100668039);
			OutgoingPacket.NativeMethodInfoPtr_get_Port_Public_get_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutgoingPacket>.NativeClassPtr, 100668040);
			OutgoingPacket.NativeMethodInfoPtr_set_Port_Internal_set_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutgoingPacket>.NativeClassPtr, 100668041);
			OutgoingPacket.NativeMethodInfoPtr_get_Data_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutgoingPacket>.NativeClassPtr, 100668042);
			OutgoingPacket.NativeMethodInfoPtr_set_Data_Internal_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutgoingPacket>.NativeClassPtr, 100668043);
			OutgoingPacket.NativeMethodInfoPtr_get_Size_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutgoingPacket>.NativeClassPtr, 100668044);
			OutgoingPacket.NativeMethodInfoPtr_set_Size_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutgoingPacket>.NativeClassPtr, 100668045);
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x060019F0 RID: 6640 RVA: 0x0007D344 File Offset: 0x0007B544
		// (set) Token: 0x060019F1 RID: 6641 RVA: 0x0007D388 File Offset: 0x0007B588
		public unsafe uint Address
		{
			[CallerCount(200)]
			[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutgoingPacket.NativeMethodInfoPtr_get_Address_Public_get_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 320163, RefRangeEnd = 320170, XrefRangeStart = 320163, XrefRangeEnd = 320170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutgoingPacket.NativeMethodInfoPtr_set_Address_Internal_set_Void_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x060019F2 RID: 6642 RVA: 0x0007D3CC File Offset: 0x0007B5CC
		// (set) Token: 0x060019F3 RID: 6643 RVA: 0x0007D410 File Offset: 0x0007B610
		public unsafe ushort Port
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutgoingPacket.NativeMethodInfoPtr_get_Port_Public_get_UInt16_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutgoingPacket.NativeMethodInfoPtr_set_Port_Internal_set_Void_UInt16_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x060019F4 RID: 6644 RVA: 0x0007D454 File Offset: 0x0007B654
		// (set) Token: 0x060019F5 RID: 6645 RVA: 0x0007D498 File Offset: 0x0007B698
		public unsafe Il2CppStructArray<byte> Data
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutgoingPacket.NativeMethodInfoPtr_get_Data_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 315685, RefRangeEnd = 315686, XrefRangeStart = 315685, XrefRangeEnd = 315686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutgoingPacket.NativeMethodInfoPtr_set_Data_Internal_set_Void_Il2CppStructArray_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x060019F6 RID: 6646 RVA: 0x0007D4E0 File Offset: 0x0007B6E0
		// (set) Token: 0x060019F7 RID: 6647 RVA: 0x0007D524 File Offset: 0x0007B724
		public unsafe int Size
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutgoingPacket.NativeMethodInfoPtr_get_Size_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OutgoingPacket.NativeMethodInfoPtr_set_Size_Internal_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x00008714 File Offset: 0x00006914
		public OutgoingPacket(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x0000871D File Offset: 0x0000691D
		public OutgoingPacket()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutgoingPacket>.NativeClassPtr))
		{
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x060019FA RID: 6650 RVA: 0x0007D568 File Offset: 0x0007B768
		// (set) Token: 0x060019FB RID: 6651 RVA: 0x0000872F File Offset: 0x0000692F
		public unsafe uint _Address_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutgoingPacket.NativeFieldInfoPtr__Address_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutgoingPacket.NativeFieldInfoPtr__Address_k__BackingField)) = value;
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x060019FC RID: 6652 RVA: 0x0007D590 File Offset: 0x0007B790
		// (set) Token: 0x060019FD RID: 6653 RVA: 0x0000874A File Offset: 0x0000694A
		public unsafe ushort _Port_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutgoingPacket.NativeFieldInfoPtr__Port_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutgoingPacket.NativeFieldInfoPtr__Port_k__BackingField)) = value;
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x060019FE RID: 6654 RVA: 0x0007D5B8 File Offset: 0x0007B7B8
		// (set) Token: 0x060019FF RID: 6655 RVA: 0x00008765 File Offset: 0x00006965
		public unsafe Il2CppStructArray<byte> _Data_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutgoingPacket.NativeFieldInfoPtr__Data_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutgoingPacket.NativeFieldInfoPtr__Data_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06001A00 RID: 6656 RVA: 0x0007D5E8 File Offset: 0x0007B7E8
		// (set) Token: 0x06001A01 RID: 6657 RVA: 0x00008784 File Offset: 0x00006984
		public unsafe int _Size_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutgoingPacket.NativeFieldInfoPtr__Size_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OutgoingPacket.NativeFieldInfoPtr__Size_k__BackingField)) = value;
			}
		}

		// Token: 0x04001F19 RID: 7961
		private static readonly IntPtr NativeFieldInfoPtr__Address_k__BackingField;

		// Token: 0x04001F1A RID: 7962
		private static readonly IntPtr NativeFieldInfoPtr__Port_k__BackingField;

		// Token: 0x04001F1B RID: 7963
		private static readonly IntPtr NativeFieldInfoPtr__Data_k__BackingField;

		// Token: 0x04001F1C RID: 7964
		private static readonly IntPtr NativeFieldInfoPtr__Size_k__BackingField;

		// Token: 0x04001F1D RID: 7965
		private static readonly IntPtr NativeMethodInfoPtr_get_Address_Public_get_UInt32_0;

		// Token: 0x04001F1E RID: 7966
		private static readonly IntPtr NativeMethodInfoPtr_set_Address_Internal_set_Void_UInt32_0;

		// Token: 0x04001F1F RID: 7967
		private static readonly IntPtr NativeMethodInfoPtr_get_Port_Public_get_UInt16_0;

		// Token: 0x04001F20 RID: 7968
		private static readonly IntPtr NativeMethodInfoPtr_set_Port_Internal_set_Void_UInt16_0;

		// Token: 0x04001F21 RID: 7969
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001F22 RID: 7970
		private static readonly IntPtr NativeMethodInfoPtr_set_Data_Internal_set_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001F23 RID: 7971
		private static readonly IntPtr NativeMethodInfoPtr_get_Size_Public_get_Int32_0;

		// Token: 0x04001F24 RID: 7972
		private static readonly IntPtr NativeMethodInfoPtr_set_Size_Internal_set_Void_Int32_0;
	}
}
