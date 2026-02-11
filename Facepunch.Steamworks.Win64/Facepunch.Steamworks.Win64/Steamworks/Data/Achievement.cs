using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;

namespace Steamworks.Data
{
	// Token: 0x020001F6 RID: 502
	public sealed class Achievement : ValueType
	{
		// Token: 0x06001932 RID: 6450 RVA: 0x0007A674 File Offset: 0x00078874
		// Note: this type is marked as 'beforefieldinit'.
		static Achievement()
		{
			Il2CppClassPointerStore<Achievement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "Achievement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Achievement>.NativeClassPtr);
			Achievement.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Achievement>.NativeClassPtr, "Value");
			Achievement.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievement>.NativeClassPtr, 100667895);
			Achievement.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievement>.NativeClassPtr, 100667896);
			Achievement.NativeMethodInfoPtr_get_State_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievement>.NativeClassPtr, 100667897);
			Achievement.NativeMethodInfoPtr_get_Identifier_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievement>.NativeClassPtr, 100667898);
			Achievement.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievement>.NativeClassPtr, 100667899);
			Achievement.NativeMethodInfoPtr_get_Description_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievement>.NativeClassPtr, 100667900);
			Achievement.NativeMethodInfoPtr_get_UnlockTime_Public_get_Nullable_1_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievement>.NativeClassPtr, 100667901);
			Achievement.NativeMethodInfoPtr_GetIcon_Public_Nullable_1_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievement>.NativeClassPtr, 100667902);
			Achievement.NativeMethodInfoPtr_GetIconAsync_Public_Task_1_Nullable_1_Image_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievement>.NativeClassPtr, 100667903);
			Achievement.NativeMethodInfoPtr_get_GlobalUnlocked_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievement>.NativeClassPtr, 100667904);
			Achievement.NativeMethodInfoPtr_Trigger_Public_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievement>.NativeClassPtr, 100667905);
			Achievement.NativeMethodInfoPtr_Clear_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievement>.NativeClassPtr, 100667906);
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x0007A7A8 File Offset: 0x000789A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Achievement(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Achievement>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievement.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x0007A7F8 File Offset: 0x000789F8
		[CallerCount(99)]
		[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievement.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001935 RID: 6453 RVA: 0x0007A834 File Offset: 0x00078A34
		public unsafe bool State
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951781, XrefRangeEnd = 951783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievement.NativeMethodInfoPtr_get_State_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06001936 RID: 6454 RVA: 0x0007A878 File Offset: 0x00078A78
		public unsafe string Identifier
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievement.NativeMethodInfoPtr_get_Identifier_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001937 RID: 6455 RVA: 0x0007A8B4 File Offset: 0x00078AB4
		public unsafe string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951783, XrefRangeEnd = 951788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievement.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001938 RID: 6456 RVA: 0x0007A8F0 File Offset: 0x00078AF0
		public unsafe string Description
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951788, XrefRangeEnd = 951793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievement.NativeMethodInfoPtr_get_Description_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001939 RID: 6457 RVA: 0x0007A92C File Offset: 0x00078B2C
		public unsafe Nullable<DateTime> UnlockTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951793, XrefRangeEnd = 951806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievement.NativeMethodInfoPtr_get_UnlockTime_Public_get_Nullable_1_DateTime_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<DateTime>(intPtr);
			}
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x0007A968 File Offset: 0x00078B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951806, XrefRangeEnd = 951812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Nullable<Image> GetIcon()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievement.NativeMethodInfoPtr_GetIcon_Public_Nullable_1_Image_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<Image>(intPtr);
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x0007A9A4 File Offset: 0x00078BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951812, XrefRangeEnd = 951826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<Nullable<Image>> GetIconAsync(int timeout = 5000)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievement.NativeMethodInfoPtr_GetIconAsync_Public_Task_1_Nullable_1_Image_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<Image>>>(intPtr3) : null;
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x0600193C RID: 6460 RVA: 0x0007A9F8 File Offset: 0x00078BF8
		public unsafe float GlobalUnlocked
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951826, XrefRangeEnd = 951828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievement.NativeMethodInfoPtr_get_GlobalUnlocked_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x0007AA3C File Offset: 0x00078C3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 951832, RefRangeEnd = 951833, XrefRangeStart = 951828, XrefRangeEnd = 951832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Trigger(bool apply = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref apply;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievement.NativeMethodInfoPtr_Trigger_Public_Boolean_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x0007AA8C File Offset: 0x00078C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951833, XrefRangeEnd = 951836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievement.NativeMethodInfoPtr_Clear_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x000082C7 File Offset: 0x000064C7
		public Achievement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x000082D0 File Offset: 0x000064D0
		public Achievement()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Achievement>.NativeClassPtr))
		{
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001941 RID: 6465 RVA: 0x0007AAD0 File Offset: 0x00078CD0
		// (set) Token: 0x06001942 RID: 6466 RVA: 0x000082E2 File Offset: 0x000064E2
		public unsafe string Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievement.NativeFieldInfoPtr_Value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievement.NativeFieldInfoPtr_Value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001E76 RID: 7798
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001E77 RID: 7799
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001E78 RID: 7800
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001E79 RID: 7801
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_Boolean_0;

		// Token: 0x04001E7A RID: 7802
		private static readonly IntPtr NativeMethodInfoPtr_get_Identifier_Public_get_String_0;

		// Token: 0x04001E7B RID: 7803
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04001E7C RID: 7804
		private static readonly IntPtr NativeMethodInfoPtr_get_Description_Public_get_String_0;

		// Token: 0x04001E7D RID: 7805
		private static readonly IntPtr NativeMethodInfoPtr_get_UnlockTime_Public_get_Nullable_1_DateTime_0;

		// Token: 0x04001E7E RID: 7806
		private static readonly IntPtr NativeMethodInfoPtr_GetIcon_Public_Nullable_1_Image_0;

		// Token: 0x04001E7F RID: 7807
		private static readonly IntPtr NativeMethodInfoPtr_GetIconAsync_Public_Task_1_Nullable_1_Image_Int32_0;

		// Token: 0x04001E80 RID: 7808
		private static readonly IntPtr NativeMethodInfoPtr_get_GlobalUnlocked_Public_get_Single_0;

		// Token: 0x04001E81 RID: 7809
		private static readonly IntPtr NativeMethodInfoPtr_Trigger_Public_Boolean_Boolean_0;

		// Token: 0x04001E82 RID: 7810
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Boolean_0;

		// Token: 0x020002A0 RID: 672
		[ObfuscatedName("Steamworks.Data.Achievement+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Object
		{
			// Token: 0x060021FD RID: 8701 RVA: 0x00092984 File Offset: 0x00090B84
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<Achievement.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Achievement>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Achievement.__c__DisplayClass14_0>.NativeClassPtr);
				Achievement.__c__DisplayClass14_0.NativeFieldInfoPtr_ident = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Achievement.__c__DisplayClass14_0>.NativeClassPtr, "ident");
				Achievement.__c__DisplayClass14_0.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Achievement.__c__DisplayClass14_0>.NativeClassPtr, "i");
				Achievement.__c__DisplayClass14_0.NativeFieldInfoPtr_gotCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Achievement.__c__DisplayClass14_0>.NativeClassPtr, "gotCallback");
				Achievement.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievement.__c__DisplayClass14_0>.NativeClassPtr, 100667907);
				Achievement.__c__DisplayClass14_0.NativeMethodInfoPtr_Method_Internal_Void_String_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievement.__c__DisplayClass14_0>.NativeClassPtr, 100667908);
			}

			// Token: 0x060021FE RID: 8702 RVA: 0x00092A14 File Offset: 0x00090C14
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Achievement.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievement.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021FF RID: 8703 RVA: 0x00092A50 File Offset: 0x00090C50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951723, XrefRangeEnd = 951724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_String_Int32_PDM_0(string x, int icon)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref icon;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievement.__c__DisplayClass14_0.NativeMethodInfoPtr_Method_Internal_Void_String_Int32_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002200 RID: 8704 RVA: 0x0000DAFB File Offset: 0x0000BCFB
			public __c__DisplayClass14_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008DD RID: 2269
			// (get) Token: 0x06002201 RID: 8705 RVA: 0x00092AA0 File Offset: 0x00090CA0
			// (set) Token: 0x06002202 RID: 8706 RVA: 0x0000DB04 File Offset: 0x0000BD04
			public unsafe string ident
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievement.__c__DisplayClass14_0.NativeFieldInfoPtr_ident);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievement.__c__DisplayClass14_0.NativeFieldInfoPtr_ident), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170008DE RID: 2270
			// (get) Token: 0x06002203 RID: 8707 RVA: 0x00092AC8 File Offset: 0x00090CC8
			// (set) Token: 0x06002204 RID: 8708 RVA: 0x0000DB23 File Offset: 0x0000BD23
			public unsafe int i
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievement.__c__DisplayClass14_0.NativeFieldInfoPtr_i);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievement.__c__DisplayClass14_0.NativeFieldInfoPtr_i)) = value;
				}
			}

			// Token: 0x170008DF RID: 2271
			// (get) Token: 0x06002205 RID: 8709 RVA: 0x00092AF0 File Offset: 0x00090CF0
			// (set) Token: 0x06002206 RID: 8710 RVA: 0x0000DB3E File Offset: 0x0000BD3E
			public unsafe bool gotCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievement.__c__DisplayClass14_0.NativeFieldInfoPtr_gotCallback);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievement.__c__DisplayClass14_0.NativeFieldInfoPtr_gotCallback)) = value;
				}
			}

			// Token: 0x040023A8 RID: 9128
			private static readonly IntPtr NativeFieldInfoPtr_ident;

			// Token: 0x040023A9 RID: 9129
			private static readonly IntPtr NativeFieldInfoPtr_i;

			// Token: 0x040023AA RID: 9130
			private static readonly IntPtr NativeFieldInfoPtr_gotCallback;

			// Token: 0x040023AB RID: 9131
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040023AC RID: 9132
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_String_Int32_PDM_0;
		}

		// Token: 0x020002A1 RID: 673
		[ObfuscatedName("Steamworks.Data.Achievement+<GetIconAsync>d__14")]
		public sealed class _GetIconAsync_d__14 : ValueType
		{
			// Token: 0x06002207 RID: 8711 RVA: 0x00092B18 File Offset: 0x00090D18
			// Note: this type is marked as 'beforefieldinit'.
			static _GetIconAsync_d__14()
			{
				Il2CppClassPointerStore<Achievement._GetIconAsync_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Achievement>.NativeClassPtr, "<GetIconAsync>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Achievement._GetIconAsync_d__14>.NativeClassPtr);
				Achievement._GetIconAsync_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Achievement._GetIconAsync_d__14>.NativeClassPtr, "<>1__state");
				Achievement._GetIconAsync_d__14.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Achievement._GetIconAsync_d__14>.NativeClassPtr, "<>t__builder");
				Achievement._GetIconAsync_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Achievement._GetIconAsync_d__14>.NativeClassPtr, "<>4__this");
				Achievement._GetIconAsync_d__14.NativeFieldInfoPtr_timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Achievement._GetIconAsync_d__14>.NativeClassPtr, "timeout");
				Achievement._GetIconAsync_d__14.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Achievement._GetIconAsync_d__14>.NativeClassPtr, "<>8__1");
				Achievement._GetIconAsync_d__14.NativeFieldInfoPtr__waited_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Achievement._GetIconAsync_d__14>.NativeClassPtr, "<waited>5__2");
				Achievement._GetIconAsync_d__14.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Achievement._GetIconAsync_d__14>.NativeClassPtr, "<>u__1");
				Achievement._GetIconAsync_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievement._GetIconAsync_d__14>.NativeClassPtr, 100667909);
				Achievement._GetIconAsync_d__14.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Achievement._GetIconAsync_d__14>.NativeClassPtr, 100667910);
			}

			// Token: 0x06002208 RID: 8712 RVA: 0x00092BF8 File Offset: 0x00090DF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951724, XrefRangeEnd = 951775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievement._GetIconAsync_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002209 RID: 8713 RVA: 0x00092C30 File Offset: 0x00090E30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951775, XrefRangeEnd = 951781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Achievement._GetIconAsync_d__14.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600220A RID: 8714 RVA: 0x0000DB59 File Offset: 0x0000BD59
			public _GetIconAsync_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600220B RID: 8715 RVA: 0x0000DB62 File Offset: 0x0000BD62
			public _GetIconAsync_d__14()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Achievement._GetIconAsync_d__14>.NativeClassPtr))
			{
			}

			// Token: 0x170008E0 RID: 2272
			// (get) Token: 0x0600220C RID: 8716 RVA: 0x00092C78 File Offset: 0x00090E78
			// (set) Token: 0x0600220D RID: 8717 RVA: 0x0000DB74 File Offset: 0x0000BD74
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievement._GetIconAsync_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievement._GetIconAsync_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008E1 RID: 2273
			// (get) Token: 0x0600220E RID: 8718 RVA: 0x00092CA0 File Offset: 0x00090EA0
			// (set) Token: 0x0600220F RID: 8719 RVA: 0x0000DB8F File Offset: 0x0000BD8F
			public AsyncTaskMethodBuilder<Nullable<Image>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievement._GetIconAsync_d__14.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<Image>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<Image>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievement._GetIconAsync_d__14.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<Image>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008E2 RID: 2274
			// (get) Token: 0x06002210 RID: 8720 RVA: 0x00092CD0 File Offset: 0x00090ED0
			// (set) Token: 0x06002211 RID: 8721 RVA: 0x0000DBBD File Offset: 0x0000BDBD
			public Achievement __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievement._GetIconAsync_d__14.NativeFieldInfoPtr___4__this);
					return new Achievement(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Achievement>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievement._GetIconAsync_d__14.NativeFieldInfoPtr___4__this), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Achievement>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170008E3 RID: 2275
			// (get) Token: 0x06002212 RID: 8722 RVA: 0x00092D00 File Offset: 0x00090F00
			// (set) Token: 0x06002213 RID: 8723 RVA: 0x0000DBEB File Offset: 0x0000BDEB
			public unsafe int timeout
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievement._GetIconAsync_d__14.NativeFieldInfoPtr_timeout);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievement._GetIconAsync_d__14.NativeFieldInfoPtr_timeout)) = value;
				}
			}

			// Token: 0x170008E4 RID: 2276
			// (get) Token: 0x06002214 RID: 8724 RVA: 0x00092D28 File Offset: 0x00090F28
			// (set) Token: 0x06002215 RID: 8725 RVA: 0x0000DC06 File Offset: 0x0000BE06
			public unsafe Achievement.__c__DisplayClass14_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievement._GetIconAsync_d__14.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Achievement.__c__DisplayClass14_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievement._GetIconAsync_d__14.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008E5 RID: 2277
			// (get) Token: 0x06002216 RID: 8726 RVA: 0x00092D58 File Offset: 0x00090F58
			// (set) Token: 0x06002217 RID: 8727 RVA: 0x0000DC25 File Offset: 0x0000BE25
			public unsafe int _waited_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievement._GetIconAsync_d__14.NativeFieldInfoPtr__waited_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievement._GetIconAsync_d__14.NativeFieldInfoPtr__waited_5__2)) = value;
				}
			}

			// Token: 0x170008E6 RID: 2278
			// (get) Token: 0x06002218 RID: 8728 RVA: 0x00092D80 File Offset: 0x00090F80
			// (set) Token: 0x06002219 RID: 8729 RVA: 0x0000DC40 File Offset: 0x0000BE40
			public TaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievement._GetIconAsync_d__14.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Achievement._GetIconAsync_d__14.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040023AD RID: 9133
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040023AE RID: 9134
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040023AF RID: 9135
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040023B0 RID: 9136
			private static readonly IntPtr NativeFieldInfoPtr_timeout;

			// Token: 0x040023B1 RID: 9137
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040023B2 RID: 9138
			private static readonly IntPtr NativeFieldInfoPtr__waited_5__2;

			// Token: 0x040023B3 RID: 9139
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040023B4 RID: 9140
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040023B5 RID: 9141
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
