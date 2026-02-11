using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace lotus
{
	// Token: 0x0200000C RID: 12
	public class GameAudioResolver : MonoBehaviour
	{
		// Token: 0x0600004D RID: 77 RVA: 0x000037EC File Offset: 0x000019EC
		// Note: this type is marked as 'beforefieldinit'.
		static GameAudioResolver()
		{
			Il2CppClassPointerStore<GameAudioResolver>.NativeClassPtr = IL2CPP.GetIl2CppClass("audio.dll", "lotus", "GameAudioResolver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameAudioResolver>.NativeClassPtr);
			GameAudioResolver.NativeFieldInfoPtr_folder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameAudioResolver>.NativeClassPtr, "folder");
			GameAudioResolver.NativeFieldInfoPtr_cachedResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameAudioResolver>.NativeClassPtr, "cachedResources");
			GameAudioResolver.NativeMethodInfoPtr_PoolItems_Public_Void_List_1_ResolverResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameAudioResolver>.NativeClassPtr, 100663327);
			GameAudioResolver.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_AudioSubItem_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameAudioResolver>.NativeClassPtr, 100663328);
			GameAudioResolver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameAudioResolver>.NativeClassPtr, 100663329);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003880 File Offset: 0x00001A80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1261387, RefRangeEnd = 1261388, XrefRangeStart = 1261370, XrefRangeEnd = 1261387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PoolItems(List<GameAudioResolver.ResolverResource> resources)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resources);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameAudioResolver.NativeMethodInfoPtr_PoolItems_Public_Void_List_1_ResolverResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000038C4 File Offset: 0x00001AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261388, XrefRangeEnd = 1261412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Resolve(AudioSubItem subitem, global::Il2CppSystem.Object context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(subitem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameAudioResolver.NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_AudioSubItem_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003918 File Offset: 0x00001B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261412, XrefRangeEnd = 1261423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameAudioResolver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameAudioResolver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameAudioResolver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000022AE File Offset: 0x000004AE
		public GameAudioResolver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00003954 File Offset: 0x00001B54
		// (set) Token: 0x06000053 RID: 83 RVA: 0x000022B7 File Offset: 0x000004B7
		public unsafe string folder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameAudioResolver.NativeFieldInfoPtr_folder);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameAudioResolver.NativeFieldInfoPtr_folder), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000054 RID: 84 RVA: 0x0000397C File Offset: 0x00001B7C
		// (set) Token: 0x06000055 RID: 85 RVA: 0x000022D6 File Offset: 0x000004D6
		public unsafe Dictionary<string, GameAudioResolver.ResolverResource> cachedResources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameAudioResolver.NativeFieldInfoPtr_cachedResources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, GameAudioResolver.ResolverResource>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameAudioResolver.NativeFieldInfoPtr_cachedResources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeFieldInfoPtr_folder;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeFieldInfoPtr_cachedResources;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_PoolItems_Public_Void_List_1_ResolverResource_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_Virtual_Final_New_Void_AudioSubItem_Object_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200001D RID: 29
		[Serializable]
		public class ResolverResource : global::Il2CppSystem.Object
		{
			// Token: 0x06000118 RID: 280 RVA: 0x00005E6C File Offset: 0x0000406C
			// Note: this type is marked as 'beforefieldinit'.
			static ResolverResource()
			{
				Il2CppClassPointerStore<GameAudioResolver.ResolverResource>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameAudioResolver>.NativeClassPtr, "ResolverResource");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameAudioResolver.ResolverResource>.NativeClassPtr);
				GameAudioResolver.ResolverResource.NativeFieldInfoPtr_ClipReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameAudioResolver.ResolverResource>.NativeClassPtr, "ClipReference");
				GameAudioResolver.ResolverResource.NativeFieldInfoPtr_Clip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameAudioResolver.ResolverResource>.NativeClassPtr, "Clip");
				GameAudioResolver.ResolverResource.NativeMethodInfoPtr__ctor_Public_Void_String_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameAudioResolver.ResolverResource>.NativeClassPtr, 100663330);
			}

			// Token: 0x06000119 RID: 281 RVA: 0x00005ED4 File Offset: 0x000040D4
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ResolverResource(string cr, AudioClip c)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameAudioResolver.ResolverResource>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(cr);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameAudioResolver.ResolverResource.NativeMethodInfoPtr__ctor_Public_Void_String_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600011A RID: 282 RVA: 0x000028B8 File Offset: 0x00000AB8
			public ResolverResource(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x0600011B RID: 283 RVA: 0x00005F34 File Offset: 0x00004134
			// (set) Token: 0x0600011C RID: 284 RVA: 0x000028C1 File Offset: 0x00000AC1
			public unsafe string ClipReference
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameAudioResolver.ResolverResource.NativeFieldInfoPtr_ClipReference);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameAudioResolver.ResolverResource.NativeFieldInfoPtr_ClipReference), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x0600011D RID: 285 RVA: 0x00005F5C File Offset: 0x0000415C
			// (set) Token: 0x0600011E RID: 286 RVA: 0x000028E0 File Offset: 0x00000AE0
			public unsafe AudioClip Clip
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameAudioResolver.ResolverResource.NativeFieldInfoPtr_Clip);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameAudioResolver.ResolverResource.NativeFieldInfoPtr_Clip), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000A2 RID: 162
			private static readonly IntPtr NativeFieldInfoPtr_ClipReference;

			// Token: 0x040000A3 RID: 163
			private static readonly IntPtr NativeFieldInfoPtr_Clip;

			// Token: 0x040000A4 RID: 164
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_AudioClip_0;
		}
	}
}
