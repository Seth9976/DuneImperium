using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;

namespace Steamworks.Data
{
	// Token: 0x0200020B RID: 523
	public sealed class Stat : ValueType
	{
		// Token: 0x06001A7A RID: 6778 RVA: 0x0007F0D0 File Offset: 0x0007D2D0
		// Note: this type is marked as 'beforefieldinit'.
		static Stat()
		{
			Il2CppClassPointerStore<Stat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "Stat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stat>.NativeClassPtr);
			Stat.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stat>.NativeClassPtr, "<Name>k__BackingField");
			Stat.NativeFieldInfoPtr__UserId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stat>.NativeClassPtr, "<UserId>k__BackingField");
			Stat.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100668108);
			Stat.NativeMethodInfoPtr_set_Name_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100668109);
			Stat.NativeMethodInfoPtr_get_UserId_Public_get_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100668110);
			Stat.NativeMethodInfoPtr_set_UserId_Internal_set_Void_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100668111);
			Stat.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100668112);
			Stat.NativeMethodInfoPtr__ctor_Public_Void_String_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100668113);
			Stat.NativeMethodInfoPtr_LocalUserOnly_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100668114);
			Stat.NativeMethodInfoPtr_GetGlobalFloat_Public_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100668115);
			Stat.NativeMethodInfoPtr_GetGlobalInt_Public_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100668116);
			Stat.NativeMethodInfoPtr_GetGlobalIntDaysAsync_Public_Task_1_Il2CppStructArray_1_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100668117);
			Stat.NativeMethodInfoPtr_GetGlobalFloatDays_Public_Task_1_Il2CppStructArray_1_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100668118);
			Stat.NativeMethodInfoPtr_GetFloat_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100668119);
			Stat.NativeMethodInfoPtr_GetInt_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100668120);
			Stat.NativeMethodInfoPtr_Set_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100668121);
			Stat.NativeMethodInfoPtr_Set_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100668122);
			Stat.NativeMethodInfoPtr_Add_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100668123);
			Stat.NativeMethodInfoPtr_Add_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100668124);
			Stat.NativeMethodInfoPtr_UpdateAverageRate_Public_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100668125);
			Stat.NativeMethodInfoPtr_Store_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat>.NativeClassPtr, 100668126);
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001A7B RID: 6779 RVA: 0x0007F2A4 File Offset: 0x0007D4A4
		// (set) Token: 0x06001A7C RID: 6780 RVA: 0x0007F2E0 File Offset: 0x0007D4E0
		public unsafe string Name
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_set_Name_Internal_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06001A7D RID: 6781 RVA: 0x0007F328 File Offset: 0x0007D528
		// (set) Token: 0x06001A7E RID: 6782 RVA: 0x0007F36C File Offset: 0x0007D56C
		public unsafe SteamId UserId
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_get_UserId_Public_get_SteamId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_set_UserId_Internal_set_Void_SteamId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x0007F3B0 File Offset: 0x0007D5B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952981, XrefRangeEnd = 952983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stat(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stat>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x0007F400 File Offset: 0x0007D600
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 952984, RefRangeEnd = 952986, XrefRangeStart = 952983, XrefRangeEnd = 952984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stat(string name, SteamId user)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stat>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref user;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr__ctor_Public_Void_String_SteamId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x0007F460 File Offset: 0x0007D660
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 952986, RefRangeEnd = 952994, XrefRangeStart = 952986, XrefRangeEnd = 952986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LocalUserOnly(string caller = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(caller);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_LocalUserOnly_Internal_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x0007F4A8 File Offset: 0x0007D6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952994, XrefRangeEnd = 952996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetGlobalFloat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_GetGlobalFloat_Public_Double_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x0007F4EC File Offset: 0x0007D6EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952996, XrefRangeEnd = 952998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long GetGlobalInt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_GetGlobalInt_Public_Int64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x0007F530 File Offset: 0x0007D730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952998, XrefRangeEnd = 953012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Il2CppStructArray<long>> GetGlobalIntDaysAsync(int days)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref days;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_GetGlobalIntDaysAsync_Public_Task_1_Il2CppStructArray_1_Int64_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Il2CppStructArray<long>>>(intPtr3) : null;
			}
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x0007F584 File Offset: 0x0007D784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953012, XrefRangeEnd = 953026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Il2CppStructArray<double>> GetGlobalFloatDays(int days)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref days;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_GetGlobalFloatDays_Public_Task_1_Il2CppStructArray_1_Double_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Il2CppStructArray<double>>>(intPtr3) : null;
			}
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x0007F5D8 File Offset: 0x0007D7D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 953028, RefRangeEnd = 953029, XrefRangeStart = 953026, XrefRangeEnd = 953028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetFloat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_GetFloat_Public_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x0007F61C File Offset: 0x0007D81C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 953031, RefRangeEnd = 953032, XrefRangeStart = 953029, XrefRangeEnd = 953031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetInt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_GetInt_Public_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x0007F660 File Offset: 0x0007D860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953032, XrefRangeEnd = 953038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Set(int val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_Set_Public_Boolean_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x0007F6B0 File Offset: 0x0007D8B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953038, XrefRangeEnd = 953044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Set(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_Set_Public_Boolean_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x0007F700 File Offset: 0x0007D900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953044, XrefRangeEnd = 953054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Add(int val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_Add_Public_Boolean_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x0007F750 File Offset: 0x0007D950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953054, XrefRangeEnd = 953064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Add(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_Add_Public_Boolean_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x0007F7A0 File Offset: 0x0007D9A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953064, XrefRangeEnd = 953069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UpdateAverageRate(float count, float sessionlength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sessionlength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_UpdateAverageRate_Public_Boolean_Single_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x0007F7FC File Offset: 0x0007D9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953069, XrefRangeEnd = 953075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Store()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stat.NativeMethodInfoPtr_Store_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x00008A95 File Offset: 0x00006C95
		public Stat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x00008A9E File Offset: 0x00006C9E
		public Stat()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stat>.NativeClassPtr))
		{
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06001A90 RID: 6800 RVA: 0x0007F840 File Offset: 0x0007DA40
		// (set) Token: 0x06001A91 RID: 6801 RVA: 0x00008AB0 File Offset: 0x00006CB0
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stat.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stat.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06001A92 RID: 6802 RVA: 0x0007F868 File Offset: 0x0007DA68
		// (set) Token: 0x06001A93 RID: 6803 RVA: 0x00008ACF File Offset: 0x00006CCF
		public unsafe SteamId _UserId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stat.NativeFieldInfoPtr__UserId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stat.NativeFieldInfoPtr__UserId_k__BackingField)) = value;
			}
		}

		// Token: 0x04001F7E RID: 8062
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04001F7F RID: 8063
		private static readonly IntPtr NativeFieldInfoPtr__UserId_k__BackingField;

		// Token: 0x04001F80 RID: 8064
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04001F81 RID: 8065
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Internal_set_Void_String_0;

		// Token: 0x04001F82 RID: 8066
		private static readonly IntPtr NativeMethodInfoPtr_get_UserId_Public_get_SteamId_0;

		// Token: 0x04001F83 RID: 8067
		private static readonly IntPtr NativeMethodInfoPtr_set_UserId_Internal_set_Void_SteamId_0;

		// Token: 0x04001F84 RID: 8068
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001F85 RID: 8069
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_SteamId_0;

		// Token: 0x04001F86 RID: 8070
		private static readonly IntPtr NativeMethodInfoPtr_LocalUserOnly_Internal_Void_String_0;

		// Token: 0x04001F87 RID: 8071
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalFloat_Public_Double_0;

		// Token: 0x04001F88 RID: 8072
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalInt_Public_Int64_0;

		// Token: 0x04001F89 RID: 8073
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalIntDaysAsync_Public_Task_1_Il2CppStructArray_1_Int64_Int32_0;

		// Token: 0x04001F8A RID: 8074
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalFloatDays_Public_Task_1_Il2CppStructArray_1_Double_Int32_0;

		// Token: 0x04001F8B RID: 8075
		private static readonly IntPtr NativeMethodInfoPtr_GetFloat_Public_Single_0;

		// Token: 0x04001F8C RID: 8076
		private static readonly IntPtr NativeMethodInfoPtr_GetInt_Public_Int32_0;

		// Token: 0x04001F8D RID: 8077
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Boolean_Int32_0;

		// Token: 0x04001F8E RID: 8078
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Boolean_Single_0;

		// Token: 0x04001F8F RID: 8079
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Boolean_Int32_0;

		// Token: 0x04001F90 RID: 8080
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Boolean_Single_0;

		// Token: 0x04001F91 RID: 8081
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAverageRate_Public_Boolean_Single_Single_0;

		// Token: 0x04001F92 RID: 8082
		private static readonly IntPtr NativeMethodInfoPtr_Store_Public_Boolean_0;

		// Token: 0x020002B0 RID: 688
		[ObfuscatedName("Steamworks.Data.Stat+<GetGlobalFloatDays>d__14")]
		public sealed class _GetGlobalFloatDays_d__14 : ValueType
		{
			// Token: 0x06002306 RID: 8966 RVA: 0x0009506C File Offset: 0x0009326C
			// Note: this type is marked as 'beforefieldinit'.
			static _GetGlobalFloatDays_d__14()
			{
				Il2CppClassPointerStore<Stat._GetGlobalFloatDays_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Stat>.NativeClassPtr, "<GetGlobalFloatDays>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stat._GetGlobalFloatDays_d__14>.NativeClassPtr);
				Stat._GetGlobalFloatDays_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stat._GetGlobalFloatDays_d__14>.NativeClassPtr, "<>1__state");
				Stat._GetGlobalFloatDays_d__14.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stat._GetGlobalFloatDays_d__14>.NativeClassPtr, "<>t__builder");
				Stat._GetGlobalFloatDays_d__14.NativeFieldInfoPtr_days = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stat._GetGlobalFloatDays_d__14>.NativeClassPtr, "days");
				Stat._GetGlobalFloatDays_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stat._GetGlobalFloatDays_d__14>.NativeClassPtr, "<>4__this");
				Stat._GetGlobalFloatDays_d__14.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stat._GetGlobalFloatDays_d__14>.NativeClassPtr, "<>u__1");
				Stat._GetGlobalFloatDays_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat._GetGlobalFloatDays_d__14>.NativeClassPtr, 100668127);
				Stat._GetGlobalFloatDays_d__14.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat._GetGlobalFloatDays_d__14>.NativeClassPtr, 100668128);
			}

			// Token: 0x06002307 RID: 8967 RVA: 0x00095124 File Offset: 0x00093324
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952903, XrefRangeEnd = 952936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stat._GetGlobalFloatDays_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002308 RID: 8968 RVA: 0x0009515C File Offset: 0x0009335C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952936, XrefRangeEnd = 952942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stat._GetGlobalFloatDays_d__14.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002309 RID: 8969 RVA: 0x0000E85F File Offset: 0x0000CA5F
			public _GetGlobalFloatDays_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600230A RID: 8970 RVA: 0x0000E868 File Offset: 0x0000CA68
			public _GetGlobalFloatDays_d__14()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stat._GetGlobalFloatDays_d__14>.NativeClassPtr))
			{
			}

			// Token: 0x17000939 RID: 2361
			// (get) Token: 0x0600230B RID: 8971 RVA: 0x000951A4 File Offset: 0x000933A4
			// (set) Token: 0x0600230C RID: 8972 RVA: 0x0000E87A File Offset: 0x0000CA7A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stat._GetGlobalFloatDays_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stat._GetGlobalFloatDays_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700093A RID: 2362
			// (get) Token: 0x0600230D RID: 8973 RVA: 0x000951CC File Offset: 0x000933CC
			// (set) Token: 0x0600230E RID: 8974 RVA: 0x0000E895 File Offset: 0x0000CA95
			public AsyncTaskMethodBuilder<Il2CppStructArray<double>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stat._GetGlobalFloatDays_d__14.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Il2CppStructArray<double>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppStructArray<double>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stat._GetGlobalFloatDays_d__14.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppStructArray<double>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700093B RID: 2363
			// (get) Token: 0x0600230F RID: 8975 RVA: 0x000951FC File Offset: 0x000933FC
			// (set) Token: 0x06002310 RID: 8976 RVA: 0x0000E8C3 File Offset: 0x0000CAC3
			public unsafe int days
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stat._GetGlobalFloatDays_d__14.NativeFieldInfoPtr_days);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stat._GetGlobalFloatDays_d__14.NativeFieldInfoPtr_days)) = value;
				}
			}

			// Token: 0x1700093C RID: 2364
			// (get) Token: 0x06002311 RID: 8977 RVA: 0x00095224 File Offset: 0x00093424
			// (set) Token: 0x06002312 RID: 8978 RVA: 0x0000E8DE File Offset: 0x0000CADE
			public Stat __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stat._GetGlobalFloatDays_d__14.NativeFieldInfoPtr___4__this);
					return new Stat(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Stat>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stat._GetGlobalFloatDays_d__14.NativeFieldInfoPtr___4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Stat>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700093D RID: 2365
			// (get) Token: 0x06002313 RID: 8979 RVA: 0x00095254 File Offset: 0x00093454
			// (set) Token: 0x06002314 RID: 8980 RVA: 0x0000E90C File Offset: 0x0000CB0C
			public CallResult<GlobalStatsReceived_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stat._GetGlobalFloatDays_d__14.NativeFieldInfoPtr___u__1);
					return new CallResult<GlobalStatsReceived_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<GlobalStatsReceived_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stat._GetGlobalFloatDays_d__14.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<GlobalStatsReceived_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400242C RID: 9260
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400242D RID: 9261
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400242E RID: 9262
			private static readonly IntPtr NativeFieldInfoPtr_days;

			// Token: 0x0400242F RID: 9263
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002430 RID: 9264
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002431 RID: 9265
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002432 RID: 9266
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x020002B1 RID: 689
		[ObfuscatedName("Steamworks.Data.Stat+<GetGlobalIntDaysAsync>d__13")]
		public sealed class _GetGlobalIntDaysAsync_d__13 : ValueType
		{
			// Token: 0x06002315 RID: 8981 RVA: 0x00095284 File Offset: 0x00093484
			// Note: this type is marked as 'beforefieldinit'.
			static _GetGlobalIntDaysAsync_d__13()
			{
				Il2CppClassPointerStore<Stat._GetGlobalIntDaysAsync_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Stat>.NativeClassPtr, "<GetGlobalIntDaysAsync>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stat._GetGlobalIntDaysAsync_d__13>.NativeClassPtr);
				Stat._GetGlobalIntDaysAsync_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stat._GetGlobalIntDaysAsync_d__13>.NativeClassPtr, "<>1__state");
				Stat._GetGlobalIntDaysAsync_d__13.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stat._GetGlobalIntDaysAsync_d__13>.NativeClassPtr, "<>t__builder");
				Stat._GetGlobalIntDaysAsync_d__13.NativeFieldInfoPtr_days = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stat._GetGlobalIntDaysAsync_d__13>.NativeClassPtr, "days");
				Stat._GetGlobalIntDaysAsync_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stat._GetGlobalIntDaysAsync_d__13>.NativeClassPtr, "<>4__this");
				Stat._GetGlobalIntDaysAsync_d__13.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stat._GetGlobalIntDaysAsync_d__13>.NativeClassPtr, "<>u__1");
				Stat._GetGlobalIntDaysAsync_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat._GetGlobalIntDaysAsync_d__13>.NativeClassPtr, 100668129);
				Stat._GetGlobalIntDaysAsync_d__13.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stat._GetGlobalIntDaysAsync_d__13>.NativeClassPtr, 100668130);
			}

			// Token: 0x06002316 RID: 8982 RVA: 0x0009533C File Offset: 0x0009353C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952942, XrefRangeEnd = 952975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stat._GetGlobalIntDaysAsync_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002317 RID: 8983 RVA: 0x00095374 File Offset: 0x00093574
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 952975, XrefRangeEnd = 952981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stat._GetGlobalIntDaysAsync_d__13.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002318 RID: 8984 RVA: 0x0000E93A File Offset: 0x0000CB3A
			public _GetGlobalIntDaysAsync_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002319 RID: 8985 RVA: 0x0000E943 File Offset: 0x0000CB43
			public _GetGlobalIntDaysAsync_d__13()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stat._GetGlobalIntDaysAsync_d__13>.NativeClassPtr))
			{
			}

			// Token: 0x1700093E RID: 2366
			// (get) Token: 0x0600231A RID: 8986 RVA: 0x000953BC File Offset: 0x000935BC
			// (set) Token: 0x0600231B RID: 8987 RVA: 0x0000E955 File Offset: 0x0000CB55
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stat._GetGlobalIntDaysAsync_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stat._GetGlobalIntDaysAsync_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700093F RID: 2367
			// (get) Token: 0x0600231C RID: 8988 RVA: 0x000953E4 File Offset: 0x000935E4
			// (set) Token: 0x0600231D RID: 8989 RVA: 0x0000E970 File Offset: 0x0000CB70
			public AsyncTaskMethodBuilder<Il2CppStructArray<long>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stat._GetGlobalIntDaysAsync_d__13.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Il2CppStructArray<long>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppStructArray<long>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stat._GetGlobalIntDaysAsync_d__13.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Il2CppStructArray<long>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000940 RID: 2368
			// (get) Token: 0x0600231E RID: 8990 RVA: 0x00095414 File Offset: 0x00093614
			// (set) Token: 0x0600231F RID: 8991 RVA: 0x0000E99E File Offset: 0x0000CB9E
			public unsafe int days
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stat._GetGlobalIntDaysAsync_d__13.NativeFieldInfoPtr_days);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stat._GetGlobalIntDaysAsync_d__13.NativeFieldInfoPtr_days)) = value;
				}
			}

			// Token: 0x17000941 RID: 2369
			// (get) Token: 0x06002320 RID: 8992 RVA: 0x0009543C File Offset: 0x0009363C
			// (set) Token: 0x06002321 RID: 8993 RVA: 0x0000E9B9 File Offset: 0x0000CBB9
			public Stat __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stat._GetGlobalIntDaysAsync_d__13.NativeFieldInfoPtr___4__this);
					return new Stat(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Stat>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stat._GetGlobalIntDaysAsync_d__13.NativeFieldInfoPtr___4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Stat>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000942 RID: 2370
			// (get) Token: 0x06002322 RID: 8994 RVA: 0x0009546C File Offset: 0x0009366C
			// (set) Token: 0x06002323 RID: 8995 RVA: 0x0000E9E7 File Offset: 0x0000CBE7
			public CallResult<GlobalStatsReceived_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stat._GetGlobalIntDaysAsync_d__13.NativeFieldInfoPtr___u__1);
					return new CallResult<GlobalStatsReceived_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<GlobalStatsReceived_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stat._GetGlobalIntDaysAsync_d__13.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<GlobalStatsReceived_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002433 RID: 9267
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002434 RID: 9268
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002435 RID: 9269
			private static readonly IntPtr NativeFieldInfoPtr_days;

			// Token: 0x04002436 RID: 9270
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002437 RID: 9271
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002438 RID: 9272
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002439 RID: 9273
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
