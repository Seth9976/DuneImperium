using System;
using dwd.core.loader.loaders;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace dwd.core.loader.caching
{
	// Token: 0x02000191 RID: 401
	public class SingleSpriteReference : global::Il2CppSystem.Object
	{
		// Token: 0x0600168D RID: 5773 RVA: 0x0006E588 File Offset: 0x0006C788
		// Note: this type is marked as 'beforefieldinit'.
		static SingleSpriteReference()
		{
			Il2CppClassPointerStore<SingleSpriteReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.loader.caching", "SingleSpriteReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SingleSpriteReference>.NativeClassPtr);
			SingleSpriteReference.NativeFieldInfoPtr_killed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteReference>.NativeClassPtr, "killed");
			SingleSpriteReference.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteReference>.NativeClassPtr, "source");
			SingleSpriteReference.NativeFieldInfoPtr_loadOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteReference>.NativeClassPtr, "loadOp");
			SingleSpriteReference.NativeFieldInfoPtr__Asset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteReference>.NativeClassPtr, "<Asset>k__BackingField");
			SingleSpriteReference.NativeMethodInfoPtr__ctor_Public_Void_IReferenceTracker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteReference>.NativeClassPtr, 100666742);
			SingleSpriteReference.NativeMethodInfoPtr_get_Asset_Public_Virtual_Final_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteReference>.NativeClassPtr, 100666743);
			SingleSpriteReference.NativeMethodInfoPtr_set_Asset_Private_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteReference>.NativeClassPtr, 100666744);
			SingleSpriteReference.NativeMethodInfoPtr_dwd_core_loader_caching_IAssetReference_get_Asset_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteReference>.NativeClassPtr, 100666745);
			SingleSpriteReference.NativeMethodInfoPtr_Load_Public_Virtual_Final_New_IEnumerator_AssetName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteReference>.NativeClassPtr, 100666746);
			SingleSpriteReference.NativeMethodInfoPtr_StillAlive_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteReference>.NativeClassPtr, 100666747);
			SingleSpriteReference.NativeMethodInfoPtr_GetSourceName_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteReference>.NativeClassPtr, 100666748);
			SingleSpriteReference.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteReference>.NativeClassPtr, 100666749);
			SingleSpriteReference.NativeMethodInfoPtr_Kill_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteReference>.NativeClassPtr, 100666750);
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x0006E6BC File Offset: 0x0006C8BC
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 320067, RefRangeEnd = 320078, XrefRangeStart = 320067, XrefRangeEnd = 320078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SingleSpriteReference(IReferenceTracker source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SingleSpriteReference>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteReference.NativeMethodInfoPtr__ctor_Public_Void_IReferenceTracker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x0600168F RID: 5775 RVA: 0x0006E708 File Offset: 0x0006C908
		// (set) Token: 0x06001690 RID: 5776 RVA: 0x0006E748 File Offset: 0x0006C948
		public unsafe virtual Sprite Asset
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteReference.NativeMethodInfoPtr_get_Asset_Public_Virtual_Final_New_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteReference.NativeMethodInfoPtr_set_Asset_Private_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06001691 RID: 5777 RVA: 0x0006E78C File Offset: 0x0006C98C
		public unsafe virtual global::UnityEngine.Object dwd.core.loader.caching.IAssetReference.Asset
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteReference.NativeMethodInfoPtr_dwd_core_loader_caching_IAssetReference_get_Asset_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::UnityEngine.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x0006E7CC File Offset: 0x0006C9CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878320, XrefRangeEnd = 878326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator Load(AssetName assetName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(assetName));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteReference.NativeMethodInfoPtr_Load_Public_Virtual_Final_New_IEnumerator_AssetName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x0006E824 File Offset: 0x0006CA24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878326, XrefRangeEnd = 878329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool StillAlive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteReference.NativeMethodInfoPtr_StillAlive_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x0006E860 File Offset: 0x0006CA60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878329, XrefRangeEnd = 878336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSourceName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteReference.NativeMethodInfoPtr_GetSourceName_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x0006E898 File Offset: 0x0006CA98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878336, XrefRangeEnd = 878347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteReference.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x0006E8CC File Offset: 0x0006CACC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 478427, RefRangeEnd = 478428, XrefRangeStart = 478427, XrefRangeEnd = 478428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Kill()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteReference.NativeMethodInfoPtr_Kill_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x00009E02 File Offset: 0x00008002
		public SingleSpriteReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06001698 RID: 5784 RVA: 0x0006E900 File Offset: 0x0006CB00
		// (set) Token: 0x06001699 RID: 5785 RVA: 0x00009E0B File Offset: 0x0000800B
		public unsafe bool killed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteReference.NativeFieldInfoPtr_killed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteReference.NativeFieldInfoPtr_killed)) = value;
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x0600169A RID: 5786 RVA: 0x0006E928 File Offset: 0x0006CB28
		// (set) Token: 0x0600169B RID: 5787 RVA: 0x00009E26 File Offset: 0x00008026
		public unsafe IReferenceTracker source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteReference.NativeFieldInfoPtr_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReferenceTracker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteReference.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x0600169C RID: 5788 RVA: 0x0006E958 File Offset: 0x0006CB58
		// (set) Token: 0x0600169D RID: 5789 RVA: 0x00009E45 File Offset: 0x00008045
		public Nullable<AsyncOperationHandle<Sprite>> loadOp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteReference.NativeFieldInfoPtr_loadOp);
				return new Nullable<AsyncOperationHandle<Sprite>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<AsyncOperationHandle<Sprite>>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteReference.NativeFieldInfoPtr_loadOp), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<AsyncOperationHandle<Sprite>>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x0600169E RID: 5790 RVA: 0x0006E988 File Offset: 0x0006CB88
		// (set) Token: 0x0600169F RID: 5791 RVA: 0x00009E73 File Offset: 0x00008073
		public unsafe Sprite _Asset_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteReference.NativeFieldInfoPtr__Asset_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteReference.NativeFieldInfoPtr__Asset_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FF9 RID: 4089
		private static readonly IntPtr NativeFieldInfoPtr_killed;

		// Token: 0x04000FFA RID: 4090
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x04000FFB RID: 4091
		private static readonly IntPtr NativeFieldInfoPtr_loadOp;

		// Token: 0x04000FFC RID: 4092
		private static readonly IntPtr NativeFieldInfoPtr__Asset_k__BackingField;

		// Token: 0x04000FFD RID: 4093
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IReferenceTracker_0;

		// Token: 0x04000FFE RID: 4094
		private static readonly IntPtr NativeMethodInfoPtr_get_Asset_Public_Virtual_Final_New_get_Sprite_0;

		// Token: 0x04000FFF RID: 4095
		private static readonly IntPtr NativeMethodInfoPtr_set_Asset_Private_set_Void_Sprite_0;

		// Token: 0x04001000 RID: 4096
		private static readonly IntPtr NativeMethodInfoPtr_dwd_core_loader_caching_IAssetReference_get_Asset_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001001 RID: 4097
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Final_New_IEnumerator_AssetName_0;

		// Token: 0x04001002 RID: 4098
		private static readonly IntPtr NativeMethodInfoPtr_StillAlive_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x04001003 RID: 4099
		private static readonly IntPtr NativeMethodInfoPtr_GetSourceName_Public_Virtual_Final_New_String_0;

		// Token: 0x04001004 RID: 4100
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001005 RID: 4101
		private static readonly IntPtr NativeMethodInfoPtr_Kill_Public_Virtual_Final_New_Void_0;

		// Token: 0x02000326 RID: 806
		[ObfuscatedName("dwd.core.loader.caching.SingleSpriteReference+<Load>d__10")]
		public sealed class _Load_d__10 : global::Il2CppSystem.Object
		{
			// Token: 0x060024B8 RID: 9400 RVA: 0x0009ED34 File Offset: 0x0009CF34
			// Note: this type is marked as 'beforefieldinit'.
			static _Load_d__10()
			{
				Il2CppClassPointerStore<SingleSpriteReference._Load_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SingleSpriteReference>.NativeClassPtr, "<Load>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SingleSpriteReference._Load_d__10>.NativeClassPtr);
				SingleSpriteReference._Load_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteReference._Load_d__10>.NativeClassPtr, "<>1__state");
				SingleSpriteReference._Load_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteReference._Load_d__10>.NativeClassPtr, "<>2__current");
				SingleSpriteReference._Load_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteReference._Load_d__10>.NativeClassPtr, "<>4__this");
				SingleSpriteReference._Load_d__10.NativeFieldInfoPtr_assetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteReference._Load_d__10>.NativeClassPtr, "assetName");
				SingleSpriteReference._Load_d__10.NativeFieldInfoPtr__assetRequest_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleSpriteReference._Load_d__10>.NativeClassPtr, "<assetRequest>5__2");
				SingleSpriteReference._Load_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteReference._Load_d__10>.NativeClassPtr, 100666751);
				SingleSpriteReference._Load_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteReference._Load_d__10>.NativeClassPtr, 100666752);
				SingleSpriteReference._Load_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteReference._Load_d__10>.NativeClassPtr, 100666753);
				SingleSpriteReference._Load_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteReference._Load_d__10>.NativeClassPtr, 100666754);
				SingleSpriteReference._Load_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteReference._Load_d__10>.NativeClassPtr, 100666755);
				SingleSpriteReference._Load_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleSpriteReference._Load_d__10>.NativeClassPtr, 100666756);
			}

			// Token: 0x060024B9 RID: 9401 RVA: 0x0009EE3C File Offset: 0x0009D03C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Load_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SingleSpriteReference._Load_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteReference._Load_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060024BA RID: 9402 RVA: 0x0009EE84 File Offset: 0x0009D084
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteReference._Load_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060024BB RID: 9403 RVA: 0x0009EEB8 File Offset: 0x0009D0B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878287, XrefRangeEnd = 878315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteReference._Load_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A35 RID: 2613
			// (get) Token: 0x060024BC RID: 9404 RVA: 0x0009EEF4 File Offset: 0x0009D0F4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteReference._Load_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060024BD RID: 9405 RVA: 0x0009EF34 File Offset: 0x0009D134
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 878315, XrefRangeEnd = 878320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteReference._Load_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A36 RID: 2614
			// (get) Token: 0x060024BE RID: 9406 RVA: 0x0009EF68 File Offset: 0x0009D168
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleSpriteReference._Load_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060024BF RID: 9407 RVA: 0x000107B5 File Offset: 0x0000E9B5
			public _Load_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A30 RID: 2608
			// (get) Token: 0x060024C0 RID: 9408 RVA: 0x0009EFA8 File Offset: 0x0009D1A8
			// (set) Token: 0x060024C1 RID: 9409 RVA: 0x000107BE File Offset: 0x0000E9BE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteReference._Load_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteReference._Load_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A31 RID: 2609
			// (get) Token: 0x060024C2 RID: 9410 RVA: 0x0009EFD0 File Offset: 0x0009D1D0
			// (set) Token: 0x060024C3 RID: 9411 RVA: 0x000107D9 File Offset: 0x0000E9D9
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteReference._Load_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteReference._Load_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A32 RID: 2610
			// (get) Token: 0x060024C4 RID: 9412 RVA: 0x0009F000 File Offset: 0x0009D200
			// (set) Token: 0x060024C5 RID: 9413 RVA: 0x000107F8 File Offset: 0x0000E9F8
			public unsafe SingleSpriteReference __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteReference._Load_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SingleSpriteReference>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteReference._Load_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A33 RID: 2611
			// (get) Token: 0x060024C6 RID: 9414 RVA: 0x0009F030 File Offset: 0x0009D230
			// (set) Token: 0x060024C7 RID: 9415 RVA: 0x00010817 File Offset: 0x0000EA17
			public AssetName assetName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteReference._Load_d__10.NativeFieldInfoPtr_assetName);
					return new AssetName(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetName>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteReference._Load_d__10.NativeFieldInfoPtr_assetName), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AssetName>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000A34 RID: 2612
			// (get) Token: 0x060024C8 RID: 9416 RVA: 0x0009F060 File Offset: 0x0009D260
			// (set) Token: 0x060024C9 RID: 9417 RVA: 0x00010845 File Offset: 0x0000EA45
			public unsafe SingleSpriteRequest _assetRequest_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteReference._Load_d__10.NativeFieldInfoPtr__assetRequest_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SingleSpriteRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SingleSpriteReference._Load_d__10.NativeFieldInfoPtr__assetRequest_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001900 RID: 6400
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001901 RID: 6401
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001902 RID: 6402
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001903 RID: 6403
			private static readonly IntPtr NativeFieldInfoPtr_assetName;

			// Token: 0x04001904 RID: 6404
			private static readonly IntPtr NativeFieldInfoPtr__assetRequest_5__2;

			// Token: 0x04001905 RID: 6405
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001906 RID: 6406
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001907 RID: 6407
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001908 RID: 6408
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001909 RID: 6409
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400190A RID: 6410
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
