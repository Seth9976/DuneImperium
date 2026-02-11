using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.Cryptography
{
	// Token: 0x0200002D RID: 45
	public class KeyPairPersistence : Object
	{
		// Token: 0x06000223 RID: 547 RVA: 0x0002DD98 File Offset: 0x0002BF98
		// Note: this type is marked as 'beforefieldinit'.
		static KeyPairPersistence()
		{
			Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security.Cryptography", "KeyPairPersistence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr);
			KeyPairPersistence.NativeFieldInfoPtr__userPathExists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, "_userPathExists");
			KeyPairPersistence.NativeFieldInfoPtr__userPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, "_userPath");
			KeyPairPersistence.NativeFieldInfoPtr__machinePathExists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, "_machinePathExists");
			KeyPairPersistence.NativeFieldInfoPtr__machinePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, "_machinePath");
			KeyPairPersistence.NativeFieldInfoPtr__params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, "_params");
			KeyPairPersistence.NativeFieldInfoPtr__keyvalue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, "_keyvalue");
			KeyPairPersistence.NativeFieldInfoPtr__filename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, "_filename");
			KeyPairPersistence.NativeFieldInfoPtr__container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, "_container");
			KeyPairPersistence.NativeFieldInfoPtr_lockobj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, "lockobj");
			KeyPairPersistence.NativeMethodInfoPtr__ctor_Public_Void_CspParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663616);
			KeyPairPersistence.NativeMethodInfoPtr__ctor_Public_Void_CspParameters_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663617);
			KeyPairPersistence.NativeMethodInfoPtr_get_Filename_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663618);
			KeyPairPersistence.NativeMethodInfoPtr_get_KeyValue_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663619);
			KeyPairPersistence.NativeMethodInfoPtr_set_KeyValue_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663620);
			KeyPairPersistence.NativeMethodInfoPtr_get_Parameters_Public_get_CspParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663621);
			KeyPairPersistence.NativeMethodInfoPtr_Load_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663622);
			KeyPairPersistence.NativeMethodInfoPtr_Save_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663623);
			KeyPairPersistence.NativeMethodInfoPtr_Remove_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663624);
			KeyPairPersistence.NativeMethodInfoPtr_get_UserPath_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663625);
			KeyPairPersistence.NativeMethodInfoPtr_get_MachinePath_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663626);
			KeyPairPersistence.NativeMethodInfoPtr__CanSecure_Internal_Static_Boolean_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663627);
			KeyPairPersistence.NativeMethodInfoPtr__ProtectUser_Internal_Static_Boolean_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663628);
			KeyPairPersistence.NativeMethodInfoPtr__ProtectMachine_Internal_Static_Boolean_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663629);
			KeyPairPersistence.NativeMethodInfoPtr__IsUserProtected_Internal_Static_Boolean_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663630);
			KeyPairPersistence.NativeMethodInfoPtr__IsMachineProtected_Internal_Static_Boolean_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663631);
			KeyPairPersistence.NativeMethodInfoPtr_CanSecure_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663632);
			KeyPairPersistence.NativeMethodInfoPtr_ProtectUser_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663633);
			KeyPairPersistence.NativeMethodInfoPtr_ProtectMachine_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663634);
			KeyPairPersistence.NativeMethodInfoPtr_IsUserProtected_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663635);
			KeyPairPersistence.NativeMethodInfoPtr_IsMachineProtected_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663636);
			KeyPairPersistence.NativeMethodInfoPtr_get_CanChange_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663637);
			KeyPairPersistence.NativeMethodInfoPtr_get_UseDefaultKeyContainer_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663638);
			KeyPairPersistence.NativeMethodInfoPtr_get_UseMachineKeyStore_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663639);
			KeyPairPersistence.NativeMethodInfoPtr_get_ContainerName_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663640);
			KeyPairPersistence.NativeMethodInfoPtr_Copy_Private_CspParameters_CspParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663641);
			KeyPairPersistence.NativeMethodInfoPtr_FromXml_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663642);
			KeyPairPersistence.NativeMethodInfoPtr_ToXml_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr, 100663643);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0002E0AC File Offset: 0x0002C2AC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1277904, RefRangeEnd = 1277910, XrefRangeStart = 1277894, XrefRangeEnd = 1277904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyPairPersistence(CspParameters parameters)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameters);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr__ctor_Public_Void_CspParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0002E0F8 File Offset: 0x0002C2F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277910, XrefRangeEnd = 1277920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyPairPersistence(CspParameters parameters, string keyPair)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyPairPersistence>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(keyPair);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr__ctor_Public_Void_CspParameters_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000226 RID: 550 RVA: 0x0002E158 File Offset: 0x0002C358
		public unsafe string Filename
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1277943, RefRangeEnd = 1277948, XrefRangeStart = 1277920, XrefRangeEnd = 1277943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_get_Filename_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000227 RID: 551 RVA: 0x0002E190 File Offset: 0x0002C390
		// (set) Token: 0x06000228 RID: 552 RVA: 0x0002E1C8 File Offset: 0x0002C3C8
		public unsafe string KeyValue
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_get_KeyValue_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1277949, RefRangeEnd = 1277951, XrefRangeStart = 1277948, XrefRangeEnd = 1277949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_set_KeyValue_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000229 RID: 553 RVA: 0x0002E20C File Offset: 0x0002C40C
		public unsafe CspParameters Parameters
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1277952, RefRangeEnd = 1277953, XrefRangeStart = 1277951, XrefRangeEnd = 1277952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_get_Parameters_Public_get_CspParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CspParameters>(intPtr3) : null;
			}
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0002E24C File Offset: 0x0002C44C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1277964, RefRangeEnd = 1277967, XrefRangeStart = 1277953, XrefRangeEnd = 1277964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Load()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_Load_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0002E288 File Offset: 0x0002C488
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1277986, RefRangeEnd = 1277988, XrefRangeStart = 1277967, XrefRangeEnd = 1277986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Save()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_Save_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0002E2BC File Offset: 0x0002C4BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1277990, RefRangeEnd = 1277992, XrefRangeStart = 1277988, XrefRangeEnd = 1277990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_Remove_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600022D RID: 557 RVA: 0x0002E2F0 File Offset: 0x0002C4F0
		public unsafe static string UserPath
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1278050, RefRangeEnd = 1278051, XrefRangeStart = 1277992, XrefRangeEnd = 1278050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_get_UserPath_Private_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600022E RID: 558 RVA: 0x0002E31C File Offset: 0x0002C51C
		public unsafe static string MachinePath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278051, XrefRangeEnd = 1278109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_get_MachinePath_Private_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0002E348 File Offset: 0x0002C548
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429053, RefRangeEnd = 429054, XrefRangeStart = 429053, XrefRangeEnd = 429054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _CanSecure(char* root)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = root;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr__CanSecure_Internal_Static_Boolean_ptr_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0002E384 File Offset: 0x0002C584
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429053, RefRangeEnd = 429054, XrefRangeStart = 429053, XrefRangeEnd = 429054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _ProtectUser(char* path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = path;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr__ProtectUser_Internal_Static_Boolean_ptr_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0002E3C0 File Offset: 0x0002C5C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429053, RefRangeEnd = 429054, XrefRangeStart = 429053, XrefRangeEnd = 429054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _ProtectMachine(char* path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = path;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr__ProtectMachine_Internal_Static_Boolean_ptr_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0002E3FC File Offset: 0x0002C5FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429053, RefRangeEnd = 429054, XrefRangeStart = 429053, XrefRangeEnd = 429054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _IsUserProtected(char* path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = path;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr__IsUserProtected_Internal_Static_Boolean_ptr_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0002E438 File Offset: 0x0002C638
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 429053, RefRangeEnd = 429054, XrefRangeStart = 429053, XrefRangeEnd = 429054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _IsMachineProtected(char* path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = path;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr__IsMachineProtected_Internal_Static_Boolean_ptr_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0002E474 File Offset: 0x0002C674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1278109, XrefRangeEnd = 1278115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanSecure(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_CanSecure_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0002E4B8 File Offset: 0x0002C6B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1278124, RefRangeEnd = 1278126, XrefRangeStart = 1278115, XrefRangeEnd = 1278124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ProtectUser(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_ProtectUser_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0002E4FC File Offset: 0x0002C6FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1278135, RefRangeEnd = 1278136, XrefRangeStart = 1278126, XrefRangeEnd = 1278135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ProtectMachine(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_ProtectMachine_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0002E540 File Offset: 0x0002C740
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1278145, RefRangeEnd = 1278147, XrefRangeStart = 1278136, XrefRangeEnd = 1278145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsUserProtected(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_IsUserProtected_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0002E584 File Offset: 0x0002C784
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1278156, RefRangeEnd = 1278158, XrefRangeStart = 1278147, XrefRangeEnd = 1278156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMachineProtected(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_IsMachineProtected_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000239 RID: 569 RVA: 0x0002E5C8 File Offset: 0x0002C7C8
		public unsafe bool CanChange
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 468981, RefRangeEnd = 468982, XrefRangeStart = 468981, XrefRangeEnd = 468982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_get_CanChange_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600023A RID: 570 RVA: 0x0002E604 File Offset: 0x0002C804
		public unsafe bool UseDefaultKeyContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_get_UseDefaultKeyContainer_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600023B RID: 571 RVA: 0x0002E640 File Offset: 0x0002C840
		public unsafe bool UseMachineKeyStore
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_get_UseMachineKeyStore_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600023C RID: 572 RVA: 0x0002E67C File Offset: 0x0002C87C
		public unsafe string ContainerName
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1278165, RefRangeEnd = 1278167, XrefRangeStart = 1278158, XrefRangeEnd = 1278165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_get_ContainerName_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0002E6B4 File Offset: 0x0002C8B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1278172, RefRangeEnd = 1278175, XrefRangeStart = 1278167, XrefRangeEnd = 1278172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CspParameters Copy(CspParameters p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_Copy_Private_CspParameters_CspParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CspParameters>(intPtr3) : null;
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0002E704 File Offset: 0x0002C904
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1278192, RefRangeEnd = 1278193, XrefRangeStart = 1278175, XrefRangeEnd = 1278192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FromXml(string xml)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xml);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_FromXml_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0002E748 File Offset: 0x0002C948
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1278227, RefRangeEnd = 1278228, XrefRangeStart = 1278193, XrefRangeEnd = 1278227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToXml()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyPairPersistence.NativeMethodInfoPtr_ToXml_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00002DFB File Offset: 0x00000FFB
		public KeyPairPersistence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000241 RID: 577 RVA: 0x0002E780 File Offset: 0x0002C980
		// (set) Token: 0x06000242 RID: 578 RVA: 0x00002E04 File Offset: 0x00001004
		public unsafe static bool _userPathExists
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(KeyPairPersistence.NativeFieldInfoPtr__userPathExists, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KeyPairPersistence.NativeFieldInfoPtr__userPathExists, (void*)(&value));
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000243 RID: 579 RVA: 0x0002E79C File Offset: 0x0002C99C
		// (set) Token: 0x06000244 RID: 580 RVA: 0x00002E12 File Offset: 0x00001012
		public unsafe static string _userPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KeyPairPersistence.NativeFieldInfoPtr__userPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KeyPairPersistence.NativeFieldInfoPtr__userPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000245 RID: 581 RVA: 0x0002E7BC File Offset: 0x0002C9BC
		// (set) Token: 0x06000246 RID: 582 RVA: 0x00002E24 File Offset: 0x00001024
		public unsafe static bool _machinePathExists
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(KeyPairPersistence.NativeFieldInfoPtr__machinePathExists, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KeyPairPersistence.NativeFieldInfoPtr__machinePathExists, (void*)(&value));
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000247 RID: 583 RVA: 0x0002E7D8 File Offset: 0x0002C9D8
		// (set) Token: 0x06000248 RID: 584 RVA: 0x00002E32 File Offset: 0x00001032
		public unsafe static string _machinePath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KeyPairPersistence.NativeFieldInfoPtr__machinePath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KeyPairPersistence.NativeFieldInfoPtr__machinePath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000249 RID: 585 RVA: 0x0002E7F8 File Offset: 0x0002C9F8
		// (set) Token: 0x0600024A RID: 586 RVA: 0x00002E44 File Offset: 0x00001044
		public unsafe CspParameters _params
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyPairPersistence.NativeFieldInfoPtr__params);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CspParameters>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyPairPersistence.NativeFieldInfoPtr__params), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600024B RID: 587 RVA: 0x0002E828 File Offset: 0x0002CA28
		// (set) Token: 0x0600024C RID: 588 RVA: 0x00002E63 File Offset: 0x00001063
		public unsafe string _keyvalue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyPairPersistence.NativeFieldInfoPtr__keyvalue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyPairPersistence.NativeFieldInfoPtr__keyvalue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600024D RID: 589 RVA: 0x0002E850 File Offset: 0x0002CA50
		// (set) Token: 0x0600024E RID: 590 RVA: 0x00002E82 File Offset: 0x00001082
		public unsafe string _filename
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyPairPersistence.NativeFieldInfoPtr__filename);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyPairPersistence.NativeFieldInfoPtr__filename), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600024F RID: 591 RVA: 0x0002E878 File Offset: 0x0002CA78
		// (set) Token: 0x06000250 RID: 592 RVA: 0x00002EA1 File Offset: 0x000010A1
		public unsafe string _container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyPairPersistence.NativeFieldInfoPtr__container);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyPairPersistence.NativeFieldInfoPtr__container), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000251 RID: 593 RVA: 0x0002E8A0 File Offset: 0x0002CAA0
		// (set) Token: 0x06000252 RID: 594 RVA: 0x00002EC0 File Offset: 0x000010C0
		public unsafe static Object lockobj
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KeyPairPersistence.NativeFieldInfoPtr_lockobj, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KeyPairPersistence.NativeFieldInfoPtr_lockobj, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeFieldInfoPtr__userPathExists;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeFieldInfoPtr__userPath;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeFieldInfoPtr__machinePathExists;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeFieldInfoPtr__machinePath;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeFieldInfoPtr__params;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeFieldInfoPtr__keyvalue;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeFieldInfoPtr__filename;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeFieldInfoPtr__container;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeFieldInfoPtr_lockobj;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CspParameters_0;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CspParameters_String_0;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr_get_Filename_Public_get_String_0;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr_get_KeyValue_Public_get_String_0;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr_set_KeyValue_Public_set_Void_String_0;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr_get_Parameters_Public_get_CspParameters_0;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Boolean_0;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Void_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_0;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr_get_UserPath_Private_Static_get_String_0;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeMethodInfoPtr_get_MachinePath_Private_Static_get_String_0;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeMethodInfoPtr__CanSecure_Internal_Static_Boolean_ptr_Char_0;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeMethodInfoPtr__ProtectUser_Internal_Static_Boolean_ptr_Char_0;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeMethodInfoPtr__ProtectMachine_Internal_Static_Boolean_ptr_Char_0;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeMethodInfoPtr__IsUserProtected_Internal_Static_Boolean_ptr_Char_0;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr__IsMachineProtected_Internal_Static_Boolean_ptr_Char_0;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeMethodInfoPtr_CanSecure_Private_Static_Boolean_String_0;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr_ProtectUser_Private_Static_Boolean_String_0;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr_ProtectMachine_Private_Static_Boolean_String_0;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr_IsUserProtected_Private_Static_Boolean_String_0;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr_IsMachineProtected_Private_Static_Boolean_String_0;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr_get_CanChange_Private_get_Boolean_0;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr_get_UseDefaultKeyContainer_Private_get_Boolean_0;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_get_UseMachineKeyStore_Private_get_Boolean_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr_get_ContainerName_Private_get_String_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Private_CspParameters_CspParameters_0;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr_FromXml_Private_Void_String_0;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr_ToXml_Private_String_0;
	}
}
