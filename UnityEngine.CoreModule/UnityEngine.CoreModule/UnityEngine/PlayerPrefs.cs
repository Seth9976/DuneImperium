using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200010C RID: 268
	public class PlayerPrefs : Object
	{
		// Token: 0x0600166A RID: 5738 RVA: 0x0006C474 File Offset: 0x0006A674
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerPrefs()
		{
			Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "PlayerPrefs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr);
			PlayerPrefs.NativeMethodInfoPtr_TrySetInt_Private_Static_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100666411);
			PlayerPrefs.NativeMethodInfoPtr_TrySetFloat_Private_Static_Boolean_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100666412);
			PlayerPrefs.NativeMethodInfoPtr_TrySetSetString_Private_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100666413);
			PlayerPrefs.NativeMethodInfoPtr_SetInt_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100666414);
			PlayerPrefs.NativeMethodInfoPtr_GetInt_Public_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100666415);
			PlayerPrefs.NativeMethodInfoPtr_SetFloat_Public_Static_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100666416);
			PlayerPrefs.NativeMethodInfoPtr_GetFloat_Public_Static_Single_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100666417);
			PlayerPrefs.NativeMethodInfoPtr_SetString_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100666418);
			PlayerPrefs.NativeMethodInfoPtr_GetString_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100666419);
			PlayerPrefs.NativeMethodInfoPtr_GetString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100666420);
			PlayerPrefs.NativeMethodInfoPtr_HasKey_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100666421);
			PlayerPrefs.NativeMethodInfoPtr_DeleteKey_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100666422);
			PlayerPrefs.NativeMethodInfoPtr_DeleteAll_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100666423);
			PlayerPrefs.NativeMethodInfoPtr_Save_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefs>.NativeClassPtr, 100666424);
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x0006C5BC File Offset: 0x0006A7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660056, XrefRangeEnd = 660058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TrySetInt(string key, int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_TrySetInt_Private_Static_Boolean_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x0006C60C File Offset: 0x0006A80C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660058, XrefRangeEnd = 660060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TrySetFloat(string key, float value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_TrySetFloat_Private_Static_Boolean_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x0006C65C File Offset: 0x0006A85C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660060, XrefRangeEnd = 660062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TrySetSetString(string key, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_TrySetSetString_Private_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x0006C6B0 File Offset: 0x0006A8B0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 660064, RefRangeEnd = 660072, XrefRangeStart = 660062, XrefRangeEnd = 660064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetInt(string key, int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_SetInt_Public_Static_Void_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x0006C6F4 File Offset: 0x0006A8F4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 660074, RefRangeEnd = 660081, XrefRangeStart = 660072, XrefRangeEnd = 660074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetInt(string key, int defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_GetInt_Public_Static_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x0006C744 File Offset: 0x0006A944
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 660083, RefRangeEnd = 660086, XrefRangeStart = 660081, XrefRangeEnd = 660083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetFloat(string key, float value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_SetFloat_Public_Static_Void_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x0006C788 File Offset: 0x0006A988
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 660088, RefRangeEnd = 660089, XrefRangeStart = 660086, XrefRangeEnd = 660088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetFloat(string key, float defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_GetFloat_Public_Static_Single_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x0006C7D8 File Offset: 0x0006A9D8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 660091, RefRangeEnd = 660097, XrefRangeStart = 660089, XrefRangeEnd = 660091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetString(string key, string value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_SetString_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x0006C820 File Offset: 0x0006AA20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 660099, RefRangeEnd = 660102, XrefRangeStart = 660097, XrefRangeEnd = 660099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetString(string key, string defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_GetString_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x0006C870 File Offset: 0x0006AA70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 660106, RefRangeEnd = 660108, XrefRangeStart = 660102, XrefRangeEnd = 660106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetString(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_GetString_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x0006C8AC File Offset: 0x0006AAAC
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 660110, RefRangeEnd = 660125, XrefRangeStart = 660108, XrefRangeEnd = 660110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasKey(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_HasKey_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x0006C8F0 File Offset: 0x0006AAF0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 660127, RefRangeEnd = 660134, XrefRangeStart = 660125, XrefRangeEnd = 660127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeleteKey(string key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_DeleteKey_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x0006C928 File Offset: 0x0006AB28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 660136, RefRangeEnd = 660138, XrefRangeStart = 660134, XrefRangeEnd = 660136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeleteAll()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_DeleteAll_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x0006C950 File Offset: 0x0006AB50
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 660140, RefRangeEnd = 660162, XrefRangeStart = 660138, XrefRangeEnd = 660140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Save()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPrefs.NativeMethodInfoPtr_Save_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x00008D66 File Offset: 0x00006F66
		public PlayerPrefs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x0006C978 File Offset: 0x0006AB78
		public static int GetInt(string key)
		{
			return PlayerPrefs.GetInt(key, 0);
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x0006C994 File Offset: 0x0006AB94
		public static float GetFloat(string key)
		{
			return PlayerPrefs.GetFloat(key, 0f);
		}

		// Token: 0x040014A4 RID: 5284
		private static readonly IntPtr NativeMethodInfoPtr_TrySetInt_Private_Static_Boolean_String_Int32_0;

		// Token: 0x040014A5 RID: 5285
		private static readonly IntPtr NativeMethodInfoPtr_TrySetFloat_Private_Static_Boolean_String_Single_0;

		// Token: 0x040014A6 RID: 5286
		private static readonly IntPtr NativeMethodInfoPtr_TrySetSetString_Private_Static_Boolean_String_String_0;

		// Token: 0x040014A7 RID: 5287
		private static readonly IntPtr NativeMethodInfoPtr_SetInt_Public_Static_Void_String_Int32_0;

		// Token: 0x040014A8 RID: 5288
		private static readonly IntPtr NativeMethodInfoPtr_GetInt_Public_Static_Int32_String_Int32_0;

		// Token: 0x040014A9 RID: 5289
		private static readonly IntPtr NativeMethodInfoPtr_SetFloat_Public_Static_Void_String_Single_0;

		// Token: 0x040014AA RID: 5290
		private static readonly IntPtr NativeMethodInfoPtr_GetFloat_Public_Static_Single_String_Single_0;

		// Token: 0x040014AB RID: 5291
		private static readonly IntPtr NativeMethodInfoPtr_SetString_Public_Static_Void_String_String_0;

		// Token: 0x040014AC RID: 5292
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Static_String_String_String_0;

		// Token: 0x040014AD RID: 5293
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_Static_String_String_0;

		// Token: 0x040014AE RID: 5294
		private static readonly IntPtr NativeMethodInfoPtr_HasKey_Public_Static_Boolean_String_0;

		// Token: 0x040014AF RID: 5295
		private static readonly IntPtr NativeMethodInfoPtr_DeleteKey_Public_Static_Void_String_0;

		// Token: 0x040014B0 RID: 5296
		private static readonly IntPtr NativeMethodInfoPtr_DeleteAll_Public_Static_Void_0;

		// Token: 0x040014B1 RID: 5297
		private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Static_Void_0;
	}
}
