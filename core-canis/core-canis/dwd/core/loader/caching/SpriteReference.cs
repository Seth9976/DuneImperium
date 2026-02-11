using System;
using dwd.core.loader.loaders;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace dwd.core.loader.caching
{
	// Token: 0x02000193 RID: 403
	public class SpriteReference : global::Il2CppSystem.Object
	{
		// Token: 0x060016B3 RID: 5811 RVA: 0x0006EDE8 File Offset: 0x0006CFE8
		// Note: this type is marked as 'beforefieldinit'.
		static SpriteReference()
		{
			Il2CppClassPointerStore<SpriteReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader.caching", "SpriteReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteReference>.NativeClassPtr);
			SpriteReference.NativeFieldInfoPtr_killed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteReference>.NativeClassPtr, "killed");
			SpriteReference.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteReference>.NativeClassPtr, "source");
			SpriteReference.NativeFieldInfoPtr_loadOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteReference>.NativeClassPtr, "loadOp");
			SpriteReference.NativeFieldInfoPtr__Asset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteReference>.NativeClassPtr, "<Asset>k__BackingField");
			SpriteReference.NativeMethodInfoPtr__ctor_Public_Void_IReferenceTracker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteReference>.NativeClassPtr, 100666772);
			SpriteReference.NativeMethodInfoPtr_get_Asset_Public_Virtual_Final_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteReference>.NativeClassPtr, 100666773);
			SpriteReference.NativeMethodInfoPtr_set_Asset_Private_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteReference>.NativeClassPtr, 100666774);
			SpriteReference.NativeMethodInfoPtr_dwd_core_loader_caching_IAssetReference_get_Asset_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteReference>.NativeClassPtr, 100666775);
			SpriteReference.NativeMethodInfoPtr_Load_Public_Virtual_Final_New_IEnumerator_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteReference>.NativeClassPtr, 100666776);
			SpriteReference.NativeMethodInfoPtr_StillAlive_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteReference>.NativeClassPtr, 100666777);
			SpriteReference.NativeMethodInfoPtr_GetSourceName_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteReference>.NativeClassPtr, 100666778);
			SpriteReference.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteReference>.NativeClassPtr, 100666779);
			SpriteReference.NativeMethodInfoPtr_Kill_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteReference>.NativeClassPtr, 100666780);
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x0006EF1C File Offset: 0x0006D11C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 320067, RefRangeEnd = 320078, XrefRangeStart = 320067, XrefRangeEnd = 320078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpriteReference(IReferenceTracker source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteReference>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteReference.NativeMethodInfoPtr__ctor_Public_Void_IReferenceTracker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x060016B5 RID: 5813 RVA: 0x0006EF68 File Offset: 0x0006D168
		// (set) Token: 0x060016B6 RID: 5814 RVA: 0x0006EFA8 File Offset: 0x0006D1A8
		public unsafe virtual Sprite Asset
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteReference.NativeMethodInfoPtr_get_Asset_Public_Virtual_Final_New_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteReference.NativeMethodInfoPtr_set_Asset_Private_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x060016B7 RID: 5815 RVA: 0x0006EFEC File Offset: 0x0006D1EC
		public unsafe virtual global::UnityEngine.Object dwd.core.loader.caching.IAssetReference.Asset
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteReference.NativeMethodInfoPtr_dwd_core_loader_caching_IAssetReference_get_Asset_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::UnityEngine.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x0006F02C File Offset: 0x0006D22C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878440, XrefRangeEnd = 878446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator Load(AssetName assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(assetName));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteReference.NativeMethodInfoPtr_Load_Public_Virtual_Final_New_IEnumerator_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x0006F084 File Offset: 0x0006D284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878446, XrefRangeEnd = 878449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool StillAlive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteReference.NativeMethodInfoPtr_StillAlive_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x0006F0C0 File Offset: 0x0006D2C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878449, XrefRangeEnd = 878456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSourceName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteReference.NativeMethodInfoPtr_GetSourceName_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x0006F0F8 File Offset: 0x0006D2F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878456, XrefRangeEnd = 878467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteReference.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x0006F12C File Offset: 0x0006D32C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 478427, RefRangeEnd = 478428, XrefRangeStart = 478427, XrefRangeEnd = 478428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Kill()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteReference.NativeMethodInfoPtr_Kill_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x00009F22 File Offset: 0x00008122
		public SpriteReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x060016BE RID: 5822 RVA: 0x0006F160 File Offset: 0x0006D360
		// (set) Token: 0x060016BF RID: 5823 RVA: 0x00009F2B File Offset: 0x0000812B
		public unsafe bool killed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteReference.NativeFieldInfoPtr_killed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteReference.NativeFieldInfoPtr_killed)) = value;
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x060016C0 RID: 5824 RVA: 0x0006F188 File Offset: 0x0006D388
		// (set) Token: 0x060016C1 RID: 5825 RVA: 0x00009F46 File Offset: 0x00008146
		public unsafe IReferenceTracker source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteReference.NativeFieldInfoPtr_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReferenceTracker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteReference.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x060016C2 RID: 5826 RVA: 0x0006F1B8 File Offset: 0x0006D3B8
		// (set) Token: 0x060016C3 RID: 5827 RVA: 0x00009F65 File Offset: 0x00008165
		public Nullable<AsyncOperationHandle<Il2CppReferenceArray<global::UnityEngine.Object>>> loadOp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteReference.NativeFieldInfoPtr_loadOp);
				return new Nullable<AsyncOperationHandle<Il2CppReferenceArray<global::UnityEngine.Object>>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<AsyncOperationHandle<Il2CppReferenceArray<global::UnityEngine.Object>>>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteReference.NativeFieldInfoPtr_loadOp), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<AsyncOperationHandle<Il2CppReferenceArray<global::UnityEngine.Object>>>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x060016C4 RID: 5828 RVA: 0x0006F1E8 File Offset: 0x0006D3E8
		// (set) Token: 0x060016C5 RID: 5829 RVA: 0x00009F93 File Offset: 0x00008193
		public unsafe Sprite _Asset_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteReference.NativeFieldInfoPtr__Asset_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteReference.NativeFieldInfoPtr__Asset_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001013 RID: 4115
		private static readonly IntPtr NativeFieldInfoPtr_killed;

		// Token: 0x04001014 RID: 4116
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x04001015 RID: 4117
		private static readonly IntPtr NativeFieldInfoPtr_loadOp;

		// Token: 0x04001016 RID: 4118
		private static readonly IntPtr NativeFieldInfoPtr__Asset_k__BackingField;

		// Token: 0x04001017 RID: 4119
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IReferenceTracker_0;

		// Token: 0x04001018 RID: 4120
		private static readonly IntPtr NativeMethodInfoPtr_get_Asset_Public_Virtual_Final_New_get_Sprite_0;

		// Token: 0x04001019 RID: 4121
		private static readonly IntPtr NativeMethodInfoPtr_set_Asset_Private_set_Void_Sprite_0;

		// Token: 0x0400101A RID: 4122
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_loader_caching_IAssetReference_get_Asset_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400101B RID: 4123
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Final_New_IEnumerator_AssetName_0;

		// Token: 0x0400101C RID: 4124
		private static readonly IntPtr NativeMethodInfoPtr_StillAlive_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x0400101D RID: 4125
		private static readonly IntPtr NativeMethodInfoPtr_GetSourceName_Public_Virtual_Final_New_String_0;

		// Token: 0x0400101E RID: 4126
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400101F RID: 4127
		private static readonly IntPtr NativeMethodInfoPtr_Kill_Public_Virtual_Final_New_Void_0;

		// Token: 0x02000328 RID: 808
		[ObfuscatedName("dwd.core.loader.caching.SpriteReference+<Load>d__10")]
		public sealed class _Load_d__10 : global::Il2CppSystem.Object
		{
			// Token: 0x060024DC RID: 9436 RVA: 0x0009F3EC File Offset: 0x0009D5EC
			// Note: this type is marked as 'beforefieldinit'.
			static _Load_d__10()
			{
				Il2CppClassPointerStore<SpriteReference._Load_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpriteReference>.NativeClassPtr, "<Load>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteReference._Load_d__10>.NativeClassPtr);
				SpriteReference._Load_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteReference._Load_d__10>.NativeClassPtr, "<>1__state");
				SpriteReference._Load_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteReference._Load_d__10>.NativeClassPtr, "<>2__current");
				SpriteReference._Load_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteReference._Load_d__10>.NativeClassPtr, "<>4__this");
				SpriteReference._Load_d__10.NativeFieldInfoPtr_assetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteReference._Load_d__10>.NativeClassPtr, "assetName");
				SpriteReference._Load_d__10.NativeFieldInfoPtr__assetRequest_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteReference._Load_d__10>.NativeClassPtr, "<assetRequest>5__2");
				SpriteReference._Load_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteReference._Load_d__10>.NativeClassPtr, 100666781);
				SpriteReference._Load_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteReference._Load_d__10>.NativeClassPtr, 100666782);
				SpriteReference._Load_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteReference._Load_d__10>.NativeClassPtr, 100666783);
				SpriteReference._Load_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteReference._Load_d__10>.NativeClassPtr, 100666784);
				SpriteReference._Load_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteReference._Load_d__10>.NativeClassPtr, 100666785);
				SpriteReference._Load_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteReference._Load_d__10>.NativeClassPtr, 100666786);
			}

			// Token: 0x060024DD RID: 9437 RVA: 0x0009F4F4 File Offset: 0x0009D6F4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Load_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteReference._Load_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteReference._Load_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060024DE RID: 9438 RVA: 0x0009F53C File Offset: 0x0009D73C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteReference._Load_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060024DF RID: 9439 RVA: 0x0009F570 File Offset: 0x0009D770
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878407, XrefRangeEnd = 878435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteReference._Load_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A43 RID: 2627
			// (get) Token: 0x060024E0 RID: 9440 RVA: 0x0009F5AC File Offset: 0x0009D7AC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteReference._Load_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060024E1 RID: 9441 RVA: 0x0009F5EC File Offset: 0x0009D7EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878435, XrefRangeEnd = 878440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteReference._Load_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A44 RID: 2628
			// (get) Token: 0x060024E2 RID: 9442 RVA: 0x0009F620 File Offset: 0x0009D820
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpriteReference._Load_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060024E3 RID: 9443 RVA: 0x00010913 File Offset: 0x0000EB13
			public _Load_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A3E RID: 2622
			// (get) Token: 0x060024E4 RID: 9444 RVA: 0x0009F660 File Offset: 0x0009D860
			// (set) Token: 0x060024E5 RID: 9445 RVA: 0x0001091C File Offset: 0x0000EB1C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteReference._Load_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteReference._Load_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A3F RID: 2623
			// (get) Token: 0x060024E6 RID: 9446 RVA: 0x0009F688 File Offset: 0x0009D888
			// (set) Token: 0x060024E7 RID: 9447 RVA: 0x00010937 File Offset: 0x0000EB37
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteReference._Load_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteReference._Load_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A40 RID: 2624
			// (get) Token: 0x060024E8 RID: 9448 RVA: 0x0009F6B8 File Offset: 0x0009D8B8
			// (set) Token: 0x060024E9 RID: 9449 RVA: 0x00010956 File Offset: 0x0000EB56
			public unsafe SpriteReference __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteReference._Load_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteReference>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteReference._Load_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A41 RID: 2625
			// (get) Token: 0x060024EA RID: 9450 RVA: 0x0009F6E8 File Offset: 0x0009D8E8
			// (set) Token: 0x060024EB RID: 9451 RVA: 0x00010975 File Offset: 0x0000EB75
			public AssetName assetName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteReference._Load_d__10.NativeFieldInfoPtr_assetName);
					return new AssetName(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetName>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteReference._Load_d__10.NativeFieldInfoPtr_assetName), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AssetName>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A42 RID: 2626
			// (get) Token: 0x060024EC RID: 9452 RVA: 0x0009F718 File Offset: 0x0009D918
			// (set) Token: 0x060024ED RID: 9453 RVA: 0x000109A3 File Offset: 0x0000EBA3
			public unsafe SpriteRequest _assetRequest_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteReference._Load_d__10.NativeFieldInfoPtr__assetRequest_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpriteReference._Load_d__10.NativeFieldInfoPtr__assetRequest_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001916 RID: 6422
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001917 RID: 6423
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001918 RID: 6424
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001919 RID: 6425
			private static readonly IntPtr NativeFieldInfoPtr_assetName;

			// Token: 0x0400191A RID: 6426
			private static readonly IntPtr NativeFieldInfoPtr__assetRequest_5__2;

			// Token: 0x0400191B RID: 6427
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400191C RID: 6428
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400191D RID: 6429
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400191E RID: 6430
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400191F RID: 6431
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001920 RID: 6432
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
