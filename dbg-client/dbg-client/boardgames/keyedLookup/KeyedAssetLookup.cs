using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.keyedlookup
{
	// Token: 0x02000129 RID: 297
	[Serializable]
	public class KeyedAssetLookup : KeyedSerializedLookup<Object>
	{
		// Token: 0x06000D3E RID: 3390 RVA: 0x00047524 File Offset: 0x00045724
		// Note: this type is marked as 'beforefieldinit'.
		static KeyedAssetLookup()
		{
			Il2CppClassPointerStore<KeyedAssetLookup>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.keyedlookup", "KeyedAssetLookup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyedAssetLookup>.NativeClassPtr);
			KeyedAssetLookup.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyedAssetLookup>.NativeClassPtr, "entries");
			KeyedAssetLookup.NativeMethodInfoPtr_get_Entries_Protected_Virtual_get_Il2CppReferenceArray_1_Entry_1_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedAssetLookup>.NativeClassPtr, 100665216);
			KeyedAssetLookup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedAssetLookup>.NativeClassPtr, 100665217);
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000D3F RID: 3391 RVA: 0x00047590 File Offset: 0x00045790
		public unsafe override Il2CppReferenceArray<KeyedSerializedLookup<Object>.Entry<Object>> Entries
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyedAssetLookup.NativeMethodInfoPtr_get_Entries_Protected_Virtual_get_Il2CppReferenceArray_1_Entry_1_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyedSerializedLookup<Object>.Entry<Object>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x000475DC File Offset: 0x000457DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510710, XrefRangeEnd = 510717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyedAssetLookup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyedAssetLookup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyedAssetLookup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x000086D6 File Offset: 0x000068D6
		public KeyedAssetLookup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000D42 RID: 3394 RVA: 0x00047618 File Offset: 0x00045818
		// (set) Token: 0x06000D43 RID: 3395 RVA: 0x000086DF File Offset: 0x000068DF
		public unsafe Il2CppReferenceArray<KeyedAssetLookup.AssetEntry> entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyedAssetLookup.NativeFieldInfoPtr_entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyedAssetLookup.AssetEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyedAssetLookup.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000822 RID: 2082
		private static readonly IntPtr NativeFieldInfoPtr_entries;

		// Token: 0x04000823 RID: 2083
		private static readonly IntPtr NativeMethodInfoPtr_get_Entries_Protected_Virtual_get_Il2CppReferenceArray_1_Entry_1_Object_Object_0;

		// Token: 0x04000824 RID: 2084
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000359 RID: 857
		[Serializable]
		public class AssetEntry : KeyedSerializedLookup<Object>.Entry<Object>
		{
			// Token: 0x06002862 RID: 10338 RVA: 0x000A16E0 File Offset: 0x0009F8E0
			// Note: this type is marked as 'beforefieldinit'.
			static AssetEntry()
			{
				Il2CppClassPointerStore<KeyedAssetLookup.AssetEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KeyedAssetLookup>.NativeClassPtr, "AssetEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyedAssetLookup.AssetEntry>.NativeClassPtr);
				KeyedAssetLookup.AssetEntry.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyedAssetLookup.AssetEntry>.NativeClassPtr, "key");
				KeyedAssetLookup.AssetEntry.NativeMethodInfoPtr_get_Key_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedAssetLookup.AssetEntry>.NativeClassPtr, 100665218);
				KeyedAssetLookup.AssetEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedAssetLookup.AssetEntry>.NativeClassPtr, 100665219);
			}

			// Token: 0x17000B4C RID: 2892
			// (get) Token: 0x06002863 RID: 10339 RVA: 0x000A1748 File Offset: 0x0009F948
			public unsafe override string Key
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyedAssetLookup.AssetEntry.NativeMethodInfoPtr_get_Key_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002864 RID: 10340 RVA: 0x000A178C File Offset: 0x0009F98C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 510704, XrefRangeEnd = 510710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AssetEntry()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyedAssetLookup.AssetEntry>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyedAssetLookup.AssetEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002865 RID: 10341 RVA: 0x00014DC5 File Offset: 0x00012FC5
			public AssetEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B4B RID: 2891
			// (get) Token: 0x06002866 RID: 10342 RVA: 0x000A17C8 File Offset: 0x0009F9C8
			// (set) Token: 0x06002867 RID: 10343 RVA: 0x00014DCE File Offset: 0x00012FCE
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyedAssetLookup.AssetEntry.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyedAssetLookup.AssetEntry.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400194D RID: 6477
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x0400194E RID: 6478
			private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_get_String_0;

			// Token: 0x0400194F RID: 6479
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
