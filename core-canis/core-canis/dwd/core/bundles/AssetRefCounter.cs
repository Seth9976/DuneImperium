using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.core.bundles
{
	// Token: 0x020001F9 RID: 505
	public static class AssetRefCounter : global::Il2CppSystem.Object
	{
		// Token: 0x06001BFE RID: 7166 RVA: 0x000828C8 File Offset: 0x00080AC8
		// Note: this type is marked as 'beforefieldinit'.
		static AssetRefCounter()
		{
			Il2CppClassPointerStore<AssetRefCounter>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.bundles", "AssetRefCounter");
			AssetRefCounter.NativeFieldInfoPtr_mutableRefCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRefCounter>.NativeClassPtr, "mutableRefCount");
			AssetRefCounter.NativeFieldInfoPtr_readOnlyRefCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetRefCounter>.NativeClassPtr, "readOnlyRefCount");
			AssetRefCounter.NativeMethodInfoPtr_get_RefCount_Public_Static_get_IDictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRefCounter>.NativeClassPtr, 100667735);
			AssetRefCounter.NativeMethodInfoPtr_ContainsKey_Public_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRefCounter>.NativeClassPtr, 100667736);
			AssetRefCounter.NativeMethodInfoPtr_AddTextureReference_Public_Static_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRefCounter>.NativeClassPtr, 100667737);
			AssetRefCounter.NativeMethodInfoPtr_RemoveTextureReference_Public_Static_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRefCounter>.NativeClassPtr, 100667738);
			AssetRefCounter.NativeMethodInfoPtr_AddReference_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRefCounter>.NativeClassPtr, 100667739);
			AssetRefCounter.NativeMethodInfoPtr_RemoveReference_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetRefCounter>.NativeClassPtr, 100667740);
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06001BFF RID: 7167 RVA: 0x00082990 File Offset: 0x00080B90
		public unsafe static IDictionary<int, int> RefCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885192, XrefRangeEnd = 885196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRefCounter.NativeMethodInfoPtr_get_RefCount_Public_Static_get_IDictionary_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary<int, int>>(intPtr3) : null;
			}
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x000829C4 File Offset: 0x00080BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885196, XrefRangeEnd = 885205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ContainsKey(global::UnityEngine.Object Key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRefCounter.NativeMethodInfoPtr_ContainsKey_Public_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x00082A08 File Offset: 0x00080C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885205, XrefRangeEnd = 885228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddTextureReference(Texture asset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRefCounter.NativeMethodInfoPtr_AddTextureReference_Public_Static_Void_Texture_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x00082A40 File Offset: 0x00080C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885228, XrefRangeEnd = 885252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveTextureReference(Texture asset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRefCounter.NativeMethodInfoPtr_RemoveTextureReference_Public_Static_Void_Texture_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x00082A78 File Offset: 0x00080C78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 885272, RefRangeEnd = 885273, XrefRangeStart = 885252, XrefRangeEnd = 885272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddReference(global::UnityEngine.Object asset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRefCounter.NativeMethodInfoPtr_AddReference_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x00082AB0 File Offset: 0x00080CB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 885309, RefRangeEnd = 885311, XrefRangeStart = 885273, XrefRangeEnd = 885309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoveReference(global::UnityEngine.Object asset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetRefCounter.NativeMethodInfoPtr_RemoveReference_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x0000C147 File Offset: 0x0000A347
		public AssetRefCounter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06001C06 RID: 7174 RVA: 0x00082AE8 File Offset: 0x00080CE8
		// (set) Token: 0x06001C07 RID: 7175 RVA: 0x0000C150 File Offset: 0x0000A350
		public unsafe static Dictionary<int, int> mutableRefCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AssetRefCounter.NativeFieldInfoPtr_mutableRefCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AssetRefCounter.NativeFieldInfoPtr_mutableRefCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06001C08 RID: 7176 RVA: 0x00082B10 File Offset: 0x00080D10
		// (set) Token: 0x06001C09 RID: 7177 RVA: 0x0000C162 File Offset: 0x0000A362
		public unsafe static ReadOnlyDictionary<int, int> readOnlyRefCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AssetRefCounter.NativeFieldInfoPtr_readOnlyRefCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyDictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AssetRefCounter.NativeFieldInfoPtr_readOnlyRefCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001397 RID: 5015
		private static readonly IntPtr NativeFieldInfoPtr_mutableRefCount;

		// Token: 0x04001398 RID: 5016
		private static readonly IntPtr NativeFieldInfoPtr_readOnlyRefCount;

		// Token: 0x04001399 RID: 5017
		private static readonly IntPtr NativeMethodInfoPtr_get_RefCount_Public_Static_get_IDictionary_2_Int32_Int32_0;

		// Token: 0x0400139A RID: 5018
		private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Static_Boolean_Object_0;

		// Token: 0x0400139B RID: 5019
		private static readonly IntPtr NativeMethodInfoPtr_AddTextureReference_Public_Static_Void_Texture_0;

		// Token: 0x0400139C RID: 5020
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTextureReference_Public_Static_Void_Texture_0;

		// Token: 0x0400139D RID: 5021
		private static readonly IntPtr NativeMethodInfoPtr_AddReference_Public_Static_Void_Object_0;

		// Token: 0x0400139E RID: 5022
		private static readonly IntPtr NativeMethodInfoPtr_RemoveReference_Public_Static_Void_Object_0;
	}
}
