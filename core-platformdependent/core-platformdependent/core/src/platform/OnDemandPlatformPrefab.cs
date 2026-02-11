using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace core.src.platform
{
	// Token: 0x02000007 RID: 7
	[Serializable]
	public sealed class OnDemandPlatformPrefab : ValueType
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00003570 File Offset: 0x00001770
		// Note: this type is marked as 'beforefieldinit'.
		static OnDemandPlatformPrefab()
		{
			Il2CppClassPointerStore<OnDemandPlatformPrefab>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-platformdependent.dll", "core.src.platform", "OnDemandPlatformPrefab");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnDemandPlatformPrefab>.NativeClassPtr);
			OnDemandPlatformPrefab.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDemandPlatformPrefab>.NativeClassPtr, "entries");
			OnDemandPlatformPrefab.NativeMethodInfoPtr_GetPrefab_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDemandPlatformPrefab>.NativeClassPtr, 100663305);
			OnDemandPlatformPrefab.NativeMethodInfoPtr_GetPrefab_Public_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDemandPlatformPrefab>.NativeClassPtr, 100663306);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000035DC File Offset: 0x000017DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238730, XrefRangeEnd = 1238740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetPrefab<T>() where T : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnDemandPlatformPrefab.MethodInfoStoreGeneric_GetPrefab_Public_T_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000361C File Offset: 0x0000181C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238752, RefRangeEnd = 1238753, XrefRangeStart = 1238740, XrefRangeEnd = 1238752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject GetPrefab()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnDemandPlatformPrefab.NativeMethodInfoPtr_GetPrefab_Public_GameObject_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002149 File Offset: 0x00000349
		public OnDemandPlatformPrefab(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002152 File Offset: 0x00000352
		public OnDemandPlatformPrefab()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnDemandPlatformPrefab>.NativeClassPtr))
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00003660 File Offset: 0x00001860
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00002164 File Offset: 0x00000364
		public unsafe Il2CppReferenceArray<OnDemandPlatformPrefab.Pair> entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnDemandPlatformPrefab.NativeFieldInfoPtr_entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<OnDemandPlatformPrefab.Pair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnDemandPlatformPrefab.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeFieldInfoPtr_entries;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_GetPrefab_Public_T_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_GetPrefab_Public_GameObject_0;

		// Token: 0x0200002E RID: 46
		[Serializable]
		public sealed class Pair : ValueType
		{
			// Token: 0x0600019C RID: 412 RVA: 0x00007BBC File Offset: 0x00005DBC
			// Note: this type is marked as 'beforefieldinit'.
			static Pair()
			{
				Il2CppClassPointerStore<OnDemandPlatformPrefab.Pair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OnDemandPlatformPrefab>.NativeClassPtr, "Pair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnDemandPlatformPrefab.Pair>.NativeClassPtr);
				OnDemandPlatformPrefab.Pair.NativeFieldInfoPtr_Platform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDemandPlatformPrefab.Pair>.NativeClassPtr, "Platform");
				OnDemandPlatformPrefab.Pair.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDemandPlatformPrefab.Pair>.NativeClassPtr, "Prefab");
			}

			// Token: 0x0600019D RID: 413 RVA: 0x00002BF0 File Offset: 0x00000DF0
			public Pair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600019E RID: 414 RVA: 0x00002BF9 File Offset: 0x00000DF9
			public Pair()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnDemandPlatformPrefab.Pair>.NativeClassPtr))
			{
			}

			// Token: 0x1700006E RID: 110
			// (get) Token: 0x0600019F RID: 415 RVA: 0x00007C10 File Offset: 0x00005E10
			// (set) Token: 0x060001A0 RID: 416 RVA: 0x00002C0B File Offset: 0x00000E0B
			public unsafe uint Platform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnDemandPlatformPrefab.Pair.NativeFieldInfoPtr_Platform);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnDemandPlatformPrefab.Pair.NativeFieldInfoPtr_Platform)) = value;
				}
			}

			// Token: 0x1700006F RID: 111
			// (get) Token: 0x060001A1 RID: 417 RVA: 0x00007C38 File Offset: 0x00005E38
			// (set) Token: 0x060001A2 RID: 418 RVA: 0x00002C26 File Offset: 0x00000E26
			public unsafe GameObject Prefab
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnDemandPlatformPrefab.Pair.NativeFieldInfoPtr_Prefab);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OnDemandPlatformPrefab.Pair.NativeFieldInfoPtr_Prefab), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000E8 RID: 232
			private static readonly IntPtr NativeFieldInfoPtr_Platform;

			// Token: 0x040000E9 RID: 233
			private static readonly IntPtr NativeFieldInfoPtr_Prefab;
		}

		// Token: 0x0200002F RID: 47
		private sealed class MethodInfoStoreGeneric_GetPrefab_Public_T_0<T>
		{
			// Token: 0x040000EA RID: 234
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(OnDemandPlatformPrefab.NativeMethodInfoPtr_GetPrefab_Public_T_0, Il2CppClassPointerStore<OnDemandPlatformPrefab>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
