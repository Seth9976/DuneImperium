using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001EE RID: 494
	[StructLayout(2)]
	public struct Connection
	{
		// Token: 0x060018AF RID: 6319 RVA: 0x00078D48 File Offset: 0x00076F48
		// Note: this type is marked as 'beforefieldinit'.
		static Connection()
		{
			Il2CppClassPointerStore<Connection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "Connection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Connection>.NativeClassPtr);
			Connection.NativeFieldInfoPtr__Id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Connection>.NativeClassPtr, "<Id>k__BackingField");
			Connection.NativeMethodInfoPtr_get_Id_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection>.NativeClassPtr, 100667845);
			Connection.NativeMethodInfoPtr_set_Id_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection>.NativeClassPtr, 100667846);
			Connection.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Connection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection>.NativeClassPtr, 100667847);
			Connection.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection>.NativeClassPtr, 100667848);
			Connection.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection>.NativeClassPtr, 100667849);
			Connection.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection>.NativeClassPtr, 100667850);
			Connection.NativeMethodInfoPtr_op_Implicit_Public_Static_Connection_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection>.NativeClassPtr, 100667851);
			Connection.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_Connection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection>.NativeClassPtr, 100667852);
			Connection.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Connection_Connection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection>.NativeClassPtr, 100667853);
			Connection.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Connection_Connection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection>.NativeClassPtr, 100667854);
			Connection.NativeMethodInfoPtr_Accept_Public_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection>.NativeClassPtr, 100667855);
			Connection.NativeMethodInfoPtr_Close_Public_Boolean_Boolean_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection>.NativeClassPtr, 100667856);
			Connection.NativeMethodInfoPtr_get_UserData_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection>.NativeClassPtr, 100667857);
			Connection.NativeMethodInfoPtr_set_UserData_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection>.NativeClassPtr, 100667858);
			Connection.NativeMethodInfoPtr_get_ConnectionName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection>.NativeClassPtr, 100667859);
			Connection.NativeMethodInfoPtr_set_ConnectionName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection>.NativeClassPtr, 100667860);
			Connection.NativeMethodInfoPtr_SendMessage_Public_Result_IntPtr_Int32_SendType_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection>.NativeClassPtr, 100667861);
			Connection.NativeMethodInfoPtr_SendMessage_Public_Result_Il2CppStructArray_1_Byte_SendType_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection>.NativeClassPtr, 100667862);
			Connection.NativeMethodInfoPtr_SendMessage_Public_Result_Il2CppStructArray_1_Byte_Int32_Int32_SendType_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection>.NativeClassPtr, 100667863);
			Connection.NativeMethodInfoPtr_SendMessage_Public_Result_String_SendType_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection>.NativeClassPtr, 100667864);
			Connection.NativeMethodInfoPtr_Flush_Public_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection>.NativeClassPtr, 100667865);
			Connection.NativeMethodInfoPtr_DetailedStatus_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection>.NativeClassPtr, 100667866);
			Connection.NativeMethodInfoPtr_QuickStatus_Public_ConnectionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection>.NativeClassPtr, 100667867);
			Connection.NativeMethodInfoPtr_ConfigureConnectionLanes_Public_Result_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Connection>.NativeClassPtr, 100667868);
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x060018B0 RID: 6320 RVA: 0x00078F6C File Offset: 0x0007716C
		// (set) Token: 0x060018B1 RID: 6321 RVA: 0x00078F9C File Offset: 0x0007719C
		public unsafe uint Id
		{
			[CallerCount(200)]
			[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.NativeMethodInfoPtr_get_Id_Public_get_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 320163, RefRangeEnd = 320170, XrefRangeStart = 320163, XrefRangeEnd = 320170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.NativeMethodInfoPtr_set_Id_Public_set_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x00078FD0 File Offset: 0x000771D0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 555566, RefRangeEnd = 555578, XrefRangeStart = 555566, XrefRangeEnd = 555578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Connection other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Connection_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x00079010 File Offset: 0x00077210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951571, XrefRangeEnd = 951574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x00079054 File Offset: 0x00077254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951574, XrefRangeEnd = 951575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x00079084 File Offset: 0x00077284
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 951576, RefRangeEnd = 951577, XrefRangeStart = 951575, XrefRangeEnd = 951576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x000790B0 File Offset: 0x000772B0
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Connection(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.NativeMethodInfoPtr_op_Implicit_Public_Static_Connection_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x000790F0 File Offset: 0x000772F0
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator uint(Connection value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_Connection_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x00079130 File Offset: 0x00077330
		[CallerCount(0)]
		public unsafe static bool operator ==(Connection value1, Connection value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Connection_Connection_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x0007917C File Offset: 0x0007737C
		[CallerCount(0)]
		public unsafe static bool operator !=(Connection value1, Connection value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Connection_Connection_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x000791C8 File Offset: 0x000773C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 951583, RefRangeEnd = 951584, XrefRangeStart = 951577, XrefRangeEnd = 951583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Result Accept()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.NativeMethodInfoPtr_Accept_Public_Result_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x000791F8 File Offset: 0x000773F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 951589, RefRangeEnd = 951591, XrefRangeStart = 951584, XrefRangeEnd = 951589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Close(bool linger = false, int reasonCode = 0, string debugString = "Closing Connection")
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref linger;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reasonCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(debugString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.NativeMethodInfoPtr_Close_Public_Boolean_Boolean_Int32_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x060018BC RID: 6332 RVA: 0x00079258 File Offset: 0x00077458
		// (set) Token: 0x060018BD RID: 6333 RVA: 0x00079288 File Offset: 0x00077488
		public unsafe long UserData
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 951597, RefRangeEnd = 951598, XrefRangeStart = 951591, XrefRangeEnd = 951597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.NativeMethodInfoPtr_get_UserData_Public_get_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 951604, RefRangeEnd = 951605, XrefRangeStart = 951598, XrefRangeEnd = 951604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.NativeMethodInfoPtr_set_UserData_Public_set_Void_Int64_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x060018BE RID: 6334 RVA: 0x000792BC File Offset: 0x000774BC
		// (set) Token: 0x060018BF RID: 6335 RVA: 0x000792E8 File Offset: 0x000774E8
		public unsafe string ConnectionName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 951612, RefRangeEnd = 951613, XrefRangeStart = 951605, XrefRangeEnd = 951612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.NativeMethodInfoPtr_get_ConnectionName_Public_get_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 951619, RefRangeEnd = 951620, XrefRangeStart = 951613, XrefRangeEnd = 951619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.NativeMethodInfoPtr_set_ConnectionName_Public_set_Void_String_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x00079320 File Offset: 0x00077520
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 951638, RefRangeEnd = 951641, XrefRangeStart = 951620, XrefRangeEnd = 951638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Result SendMessage(IntPtr ptr, int size, SendType sendType = SendType.Reliable, ushort laneIndex = 0)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendType;
			ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref laneIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.NativeMethodInfoPtr_SendMessage_Public_Result_IntPtr_Int32_SendType_UInt16_0, ref this, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x00079388 File Offset: 0x00077588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951641, XrefRangeEnd = 951645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Result SendMessage(Il2CppStructArray<byte> data, SendType sendType = SendType.Reliable, ushort laneIndex = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref laneIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.NativeMethodInfoPtr_SendMessage_Public_Result_Il2CppStructArray_1_Byte_SendType_UInt16_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x000793E8 File Offset: 0x000775E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951645, XrefRangeEnd = 951650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Result SendMessage(Il2CppStructArray<byte> data, int offset, int length, SendType sendType = SendType.Reliable, ushort laneIndex = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref laneIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.NativeMethodInfoPtr_SendMessage_Public_Result_Il2CppStructArray_1_Byte_Int32_Int32_SendType_UInt16_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x00079464 File Offset: 0x00077664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951650, XrefRangeEnd = 951655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Result SendMessage(string str, SendType sendType = SendType.Reliable, ushort laneIndex = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref laneIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.NativeMethodInfoPtr_SendMessage_Public_Result_String_SendType_UInt16_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x000794C4 File Offset: 0x000776C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951655, XrefRangeEnd = 951661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Result Flush()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.NativeMethodInfoPtr_Flush_Public_Result_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x000794F4 File Offset: 0x000776F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951661, XrefRangeEnd = 951666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string DetailedStatus()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.NativeMethodInfoPtr_DetailedStatus_Public_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x00079520 File Offset: 0x00077720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951666, XrefRangeEnd = 951671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConnectionStatus QuickStatus()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.NativeMethodInfoPtr_QuickStatus_Public_ConnectionStatus_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ConnectionStatus(intPtr);
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x0007954C File Offset: 0x0007774C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951671, XrefRangeEnd = 951676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Result ConfigureConnectionLanes(Il2CppStructArray<int> lanePriorities, Il2CppStructArray<ushort> laneWeights)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lanePriorities);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(laneWeights);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Connection.NativeMethodInfoPtr_ConfigureConnectionLanes_Public_Result_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt16_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x00007E69 File Offset: 0x00006069
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Connection>.NativeClassPtr, ref this));
		}

		// Token: 0x04001E1F RID: 7711
		private static readonly IntPtr NativeFieldInfoPtr__Id_k__BackingField;

		// Token: 0x04001E20 RID: 7712
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_UInt32_0;

		// Token: 0x04001E21 RID: 7713
		private static readonly IntPtr NativeMethodInfoPtr_set_Id_Public_set_Void_UInt32_0;

		// Token: 0x04001E22 RID: 7714
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Connection_0;

		// Token: 0x04001E23 RID: 7715
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001E24 RID: 7716
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001E25 RID: 7717
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001E26 RID: 7718
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Connection_UInt32_0;

		// Token: 0x04001E27 RID: 7719
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_Connection_0;

		// Token: 0x04001E28 RID: 7720
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Connection_Connection_0;

		// Token: 0x04001E29 RID: 7721
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Connection_Connection_0;

		// Token: 0x04001E2A RID: 7722
		private static readonly IntPtr NativeMethodInfoPtr_Accept_Public_Result_0;

		// Token: 0x04001E2B RID: 7723
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Boolean_Boolean_Int32_String_0;

		// Token: 0x04001E2C RID: 7724
		private static readonly IntPtr NativeMethodInfoPtr_get_UserData_Public_get_Int64_0;

		// Token: 0x04001E2D RID: 7725
		private static readonly IntPtr NativeMethodInfoPtr_set_UserData_Public_set_Void_Int64_0;

		// Token: 0x04001E2E RID: 7726
		private static readonly IntPtr NativeMethodInfoPtr_get_ConnectionName_Public_get_String_0;

		// Token: 0x04001E2F RID: 7727
		private static readonly IntPtr NativeMethodInfoPtr_set_ConnectionName_Public_set_Void_String_0;

		// Token: 0x04001E30 RID: 7728
		private static readonly IntPtr NativeMethodInfoPtr_SendMessage_Public_Result_IntPtr_Int32_SendType_UInt16_0;

		// Token: 0x04001E31 RID: 7729
		private static readonly IntPtr NativeMethodInfoPtr_SendMessage_Public_Result_Il2CppStructArray_1_Byte_SendType_UInt16_0;

		// Token: 0x04001E32 RID: 7730
		private static readonly IntPtr NativeMethodInfoPtr_SendMessage_Public_Result_Il2CppStructArray_1_Byte_Int32_Int32_SendType_UInt16_0;

		// Token: 0x04001E33 RID: 7731
		private static readonly IntPtr NativeMethodInfoPtr_SendMessage_Public_Result_String_SendType_UInt16_0;

		// Token: 0x04001E34 RID: 7732
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Result_0;

		// Token: 0x04001E35 RID: 7733
		private static readonly IntPtr NativeMethodInfoPtr_DetailedStatus_Public_String_0;

		// Token: 0x04001E36 RID: 7734
		private static readonly IntPtr NativeMethodInfoPtr_QuickStatus_Public_ConnectionStatus_0;

		// Token: 0x04001E37 RID: 7735
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureConnectionLanes_Public_Result_Il2CppStructArray_1_Int32_Il2CppStructArray_1_UInt16_0;

		// Token: 0x04001E38 RID: 7736
		[FieldOffset(0)]
		public uint _Id_k__BackingField;
	}
}
