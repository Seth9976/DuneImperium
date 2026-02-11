using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000043 RID: 67
	public class UnityKeyboardProvider : global::Il2CppSystem.Object
	{
		// Token: 0x06000668 RID: 1640 RVA: 0x0001EAB0 File Offset: 0x0001CCB0
		// Note: this type is marked as 'beforefieldinit'.
		static UnityKeyboardProvider()
		{
			Il2CppClassPointerStore<UnityKeyboardProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "UnityKeyboardProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityKeyboardProvider>.NativeClassPtr);
			UnityKeyboardProvider.NativeFieldInfoPtr_KeyMappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityKeyboardProvider>.NativeClassPtr, "KeyMappings");
			UnityKeyboardProvider.NativeMethodInfoPtr_Setup_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityKeyboardProvider>.NativeClassPtr, 100664157);
			UnityKeyboardProvider.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityKeyboardProvider>.NativeClassPtr, 100664158);
			UnityKeyboardProvider.NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityKeyboardProvider>.NativeClassPtr, 100664159);
			UnityKeyboardProvider.NativeMethodInfoPtr_AnyKeyIsPressed_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityKeyboardProvider>.NativeClassPtr, 100664160);
			UnityKeyboardProvider.NativeMethodInfoPtr_GetKeyIsPressed_Public_Virtual_Final_New_Boolean_Key_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityKeyboardProvider>.NativeClassPtr, 100664161);
			UnityKeyboardProvider.NativeMethodInfoPtr_GetNameForKey_Public_Virtual_Final_New_String_Key_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityKeyboardProvider>.NativeClassPtr, 100664162);
			UnityKeyboardProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityKeyboardProvider>.NativeClassPtr, 100664163);
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x0001EB80 File Offset: 0x0001CD80
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Setup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityKeyboardProvider.NativeMethodInfoPtr_Setup_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0001EBB4 File Offset: 0x0001CDB4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityKeyboardProvider.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x0001EBE8 File Offset: 0x0001CDE8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityKeyboardProvider.NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x0001EC1C File Offset: 0x0001CE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool AnyKeyIsPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityKeyboardProvider.NativeMethodInfoPtr_AnyKeyIsPressed_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x0001EC58 File Offset: 0x0001CE58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783301, XrefRangeEnd = 783307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetKeyIsPressed(Key control)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref control;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityKeyboardProvider.NativeMethodInfoPtr_GetKeyIsPressed_Public_Virtual_Final_New_Boolean_Key_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x0001ECA4 File Offset: 0x0001CEA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783307, XrefRangeEnd = 783991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetNameForKey(Key control)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref control;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityKeyboardProvider.NativeMethodInfoPtr_GetNameForKey_Public_Virtual_Final_New_String_Key_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x0001ECE8 File Offset: 0x0001CEE8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityKeyboardProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityKeyboardProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityKeyboardProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00004654 File Offset: 0x00002854
		public UnityKeyboardProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000671 RID: 1649 RVA: 0x0001ED24 File Offset: 0x0001CF24
		// (set) Token: 0x06000672 RID: 1650 RVA: 0x0000465D File Offset: 0x0000285D
		public unsafe static Il2CppReferenceArray<UnityKeyboardProvider.KeyMapping> KeyMappings
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UnityKeyboardProvider.NativeFieldInfoPtr_KeyMappings, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<UnityKeyboardProvider.KeyMapping>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnityKeyboardProvider.NativeFieldInfoPtr_KeyMappings, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000687 RID: 1671
		private static readonly IntPtr NativeFieldInfoPtr_KeyMappings;

		// Token: 0x04000688 RID: 1672
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000689 RID: 1673
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400068A RID: 1674
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400068B RID: 1675
		private static readonly IntPtr NativeMethodInfoPtr_AnyKeyIsPressed_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x0400068C RID: 1676
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyIsPressed_Public_Virtual_Final_New_Boolean_Key_0;

		// Token: 0x0400068D RID: 1677
		private static readonly IntPtr NativeMethodInfoPtr_GetNameForKey_Public_Virtual_Final_New_String_Key_0;

		// Token: 0x0400068E RID: 1678
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000217 RID: 535
		public sealed class KeyMapping : ValueType
		{
			// Token: 0x0600118B RID: 4491 RVA: 0x00044EEC File Offset: 0x000430EC
			// Note: this type is marked as 'beforefieldinit'.
			static KeyMapping()
			{
				Il2CppClassPointerStore<UnityKeyboardProvider.KeyMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityKeyboardProvider>.NativeClassPtr, "KeyMapping");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityKeyboardProvider.KeyMapping>.NativeClassPtr);
				UnityKeyboardProvider.KeyMapping.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityKeyboardProvider.KeyMapping>.NativeClassPtr, "source");
				UnityKeyboardProvider.KeyMapping.NativeFieldInfoPtr_target0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityKeyboardProvider.KeyMapping>.NativeClassPtr, "target0");
				UnityKeyboardProvider.KeyMapping.NativeFieldInfoPtr_target1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityKeyboardProvider.KeyMapping>.NativeClassPtr, "target1");
				UnityKeyboardProvider.KeyMapping.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityKeyboardProvider.KeyMapping>.NativeClassPtr, "name");
				UnityKeyboardProvider.KeyMapping.NativeFieldInfoPtr_macName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityKeyboardProvider.KeyMapping>.NativeClassPtr, "macName");
				UnityKeyboardProvider.KeyMapping.NativeMethodInfoPtr__ctor_Public_Void_Key_String_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityKeyboardProvider.KeyMapping>.NativeClassPtr, 100664165);
				UnityKeyboardProvider.KeyMapping.NativeMethodInfoPtr__ctor_Public_Void_Key_String_KeyCode_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityKeyboardProvider.KeyMapping>.NativeClassPtr, 100664166);
				UnityKeyboardProvider.KeyMapping.NativeMethodInfoPtr__ctor_Public_Void_Key_String_String_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityKeyboardProvider.KeyMapping>.NativeClassPtr, 100664167);
				UnityKeyboardProvider.KeyMapping.NativeMethodInfoPtr__ctor_Public_Void_Key_String_String_KeyCode_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityKeyboardProvider.KeyMapping>.NativeClassPtr, 100664168);
				UnityKeyboardProvider.KeyMapping.NativeMethodInfoPtr_get_IsPressed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityKeyboardProvider.KeyMapping>.NativeClassPtr, 100664169);
				UnityKeyboardProvider.KeyMapping.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityKeyboardProvider.KeyMapping>.NativeClassPtr, 100664170);
			}

			// Token: 0x0600118C RID: 4492 RVA: 0x00044FF4 File Offset: 0x000431F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783283, XrefRangeEnd = 783285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyMapping(Key source, string name, KeyCode target)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityKeyboardProvider.KeyMapping>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref source;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityKeyboardProvider.KeyMapping.NativeMethodInfoPtr__ctor_Public_Void_Key_String_KeyCode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600118D RID: 4493 RVA: 0x00045060 File Offset: 0x00043260
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783285, XrefRangeEnd = 783287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyMapping(Key source, string name, KeyCode target0, KeyCode target1)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityKeyboardProvider.KeyMapping>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref source;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target0;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityKeyboardProvider.KeyMapping.NativeMethodInfoPtr__ctor_Public_Void_Key_String_KeyCode_KeyCode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600118E RID: 4494 RVA: 0x000450DC File Offset: 0x000432DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783287, XrefRangeEnd = 783289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyMapping(Key source, string name, string macName, KeyCode target)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityKeyboardProvider.KeyMapping>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref source;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(macName);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityKeyboardProvider.KeyMapping.NativeMethodInfoPtr__ctor_Public_Void_Key_String_String_KeyCode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600118F RID: 4495 RVA: 0x0004515C File Offset: 0x0004335C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783289, XrefRangeEnd = 783291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeyMapping(Key source, string name, string macName, KeyCode target0, KeyCode target1)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityKeyboardProvider.KeyMapping>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref source;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(macName);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target0;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityKeyboardProvider.KeyMapping.NativeMethodInfoPtr__ctor_Public_Void_Key_String_String_KeyCode_KeyCode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170003D6 RID: 982
			// (get) Token: 0x06001190 RID: 4496 RVA: 0x000451E8 File Offset: 0x000433E8
			public unsafe bool IsPressed
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783291, XrefRangeEnd = 783293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityKeyboardProvider.KeyMapping.NativeMethodInfoPtr_get_IsPressed_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170003D7 RID: 983
			// (get) Token: 0x06001191 RID: 4497 RVA: 0x0004522C File Offset: 0x0004342C
			public unsafe string Name
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 783300, RefRangeEnd = 783301, XrefRangeStart = 783293, XrefRangeEnd = 783300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityKeyboardProvider.KeyMapping.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001192 RID: 4498 RVA: 0x000070BB File Offset: 0x000052BB
			public KeyMapping(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001193 RID: 4499 RVA: 0x000070C4 File Offset: 0x000052C4
			public KeyMapping()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityKeyboardProvider.KeyMapping>.NativeClassPtr))
			{
			}

			// Token: 0x170003D1 RID: 977
			// (get) Token: 0x06001194 RID: 4500 RVA: 0x00045268 File Offset: 0x00043468
			// (set) Token: 0x06001195 RID: 4501 RVA: 0x000070D6 File Offset: 0x000052D6
			public unsafe Key source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityKeyboardProvider.KeyMapping.NativeFieldInfoPtr_source);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityKeyboardProvider.KeyMapping.NativeFieldInfoPtr_source)) = value;
				}
			}

			// Token: 0x170003D2 RID: 978
			// (get) Token: 0x06001196 RID: 4502 RVA: 0x00045290 File Offset: 0x00043490
			// (set) Token: 0x06001197 RID: 4503 RVA: 0x000070F1 File Offset: 0x000052F1
			public unsafe KeyCode target0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityKeyboardProvider.KeyMapping.NativeFieldInfoPtr_target0);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityKeyboardProvider.KeyMapping.NativeFieldInfoPtr_target0)) = value;
				}
			}

			// Token: 0x170003D3 RID: 979
			// (get) Token: 0x06001198 RID: 4504 RVA: 0x000452B8 File Offset: 0x000434B8
			// (set) Token: 0x06001199 RID: 4505 RVA: 0x0000710C File Offset: 0x0000530C
			public unsafe KeyCode target1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityKeyboardProvider.KeyMapping.NativeFieldInfoPtr_target1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityKeyboardProvider.KeyMapping.NativeFieldInfoPtr_target1)) = value;
				}
			}

			// Token: 0x170003D4 RID: 980
			// (get) Token: 0x0600119A RID: 4506 RVA: 0x000452E0 File Offset: 0x000434E0
			// (set) Token: 0x0600119B RID: 4507 RVA: 0x00007127 File Offset: 0x00005327
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityKeyboardProvider.KeyMapping.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityKeyboardProvider.KeyMapping.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170003D5 RID: 981
			// (get) Token: 0x0600119C RID: 4508 RVA: 0x00045308 File Offset: 0x00043508
			// (set) Token: 0x0600119D RID: 4509 RVA: 0x00007146 File Offset: 0x00005346
			public unsafe string macName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityKeyboardProvider.KeyMapping.NativeFieldInfoPtr_macName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityKeyboardProvider.KeyMapping.NativeFieldInfoPtr_macName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000D9B RID: 3483
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04000D9C RID: 3484
			private static readonly IntPtr NativeFieldInfoPtr_target0;

			// Token: 0x04000D9D RID: 3485
			private static readonly IntPtr NativeFieldInfoPtr_target1;

			// Token: 0x04000D9E RID: 3486
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04000D9F RID: 3487
			private static readonly IntPtr NativeFieldInfoPtr_macName;

			// Token: 0x04000DA0 RID: 3488
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Key_String_KeyCode_0;

			// Token: 0x04000DA1 RID: 3489
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Key_String_KeyCode_KeyCode_0;

			// Token: 0x04000DA2 RID: 3490
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Key_String_String_KeyCode_0;

			// Token: 0x04000DA3 RID: 3491
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Key_String_String_KeyCode_KeyCode_0;

			// Token: 0x04000DA4 RID: 3492
			private static readonly IntPtr NativeMethodInfoPtr_get_IsPressed_Public_get_Boolean_0;

			// Token: 0x04000DA5 RID: 3493
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;
		}
	}
}
