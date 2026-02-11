using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace lotus
{
	// Token: 0x0200004F RID: 79
	public class EntitiesObserver : Object
	{
		// Token: 0x060004B2 RID: 1202 RVA: 0x00018958 File Offset: 0x00016B58
		// Note: this type is marked as 'beforefieldinit'.
		static EntitiesObserver()
		{
			Il2CppClassPointerStore<EntitiesObserver>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "EntitiesObserver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntitiesObserver>.NativeClassPtr);
			EntitiesObserver.NativeFieldInfoPtr_observedDatum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitiesObserver>.NativeClassPtr, "observedDatum");
			EntitiesObserver.NativeFieldInfoPtr_parents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitiesObserver>.NativeClassPtr, "parents");
			EntitiesObserver.NativeFieldInfoPtr_children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitiesObserver>.NativeClassPtr, "children");
			EntitiesObserver.NativeFieldInfoPtr_children2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitiesObserver>.NativeClassPtr, "children2");
			EntitiesObserver.NativeFieldInfoPtr_notifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitiesObserver>.NativeClassPtr, "notifiers");
			EntitiesObserver.NativeFieldInfoPtr_um = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitiesObserver>.NativeClassPtr, "um");
			EntitiesObserver.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitiesObserver>.NativeClassPtr, "name");
			EntitiesObserver.NativeFieldInfoPtr_dirtyNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitiesObserver>.NativeClassPtr, "dirtyNode");
			EntitiesObserver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesObserver>.NativeClassPtr, 100663864);
			EntitiesObserver.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesObserver>.NativeClassPtr, 100663865);
			EntitiesObserver.NativeMethodInfoPtr_ObserveEntity_Public_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesObserver>.NativeClassPtr, 100663866);
			EntitiesObserver.NativeMethodInfoPtr_MarkDirty_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesObserver>.NativeClassPtr, 100663867);
			EntitiesObserver.NativeMethodInfoPtr_UnobserveEntity_Public_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesObserver>.NativeClassPtr, 100663868);
			EntitiesObserver.NativeMethodInfoPtr_ObserveParentAndChildren_Public_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesObserver>.NativeClassPtr, 100663869);
			EntitiesObserver.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesObserver>.NativeClassPtr, 100663870);
			EntitiesObserver.NativeMethodInfoPtr_initParentChildCollections_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesObserver>.NativeClassPtr, 100663871);
			EntitiesObserver.NativeMethodInfoPtr_AddNotifier_Public_Void_IAmDirty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesObserver>.NativeClassPtr, 100663872);
			EntitiesObserver.NativeMethodInfoPtr_RemoveNotifier_Public_Void_IAmDirty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesObserver>.NativeClassPtr, 100663873);
			EntitiesObserver.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesObserver>.NativeClassPtr, 100663874);
			EntitiesObserver.NativeMethodInfoPtr_get_DirtyNode_Public_Virtual_Final_New_get_LinkedListNode_1_IAmDirty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesObserver>.NativeClassPtr, 100663875);
			EntitiesObserver.NativeMethodInfoPtr_set_DirtyNode_Private_set_Void_LinkedListNode_1_IAmDirty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesObserver>.NativeClassPtr, 100663876);
			EntitiesObserver.NativeMethodInfoPtr_updateChildren_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesObserver>.NativeClassPtr, 100663877);
			EntitiesObserver.NativeMethodInfoPtr_notifyObservers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesObserver>.NativeClassPtr, 100663878);
			EntitiesObserver.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesObserver>.NativeClassPtr, 100663879);
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00018B68 File Offset: 0x00016D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110794, XrefRangeEnd = 1110816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntitiesObserver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntitiesObserver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitiesObserver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00018BA4 File Offset: 0x00016DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110816, XrefRangeEnd = 1110820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitiesObserver.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00018BD8 File Offset: 0x00016DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110820, XrefRangeEnd = 1110825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ObserveEntity(EntityComponent entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitiesObserver.NativeMethodInfoPtr_ObserveEntity_Public_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00018C1C File Offset: 0x00016E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110825, XrefRangeEnd = 1110827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitiesObserver.NativeMethodInfoPtr_MarkDirty_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00018C50 File Offset: 0x00016E50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110827, XrefRangeEnd = 1110832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnobserveEntity(EntityComponent entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitiesObserver.NativeMethodInfoPtr_UnobserveEntity_Public_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00018C94 File Offset: 0x00016E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110832, XrefRangeEnd = 1110855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ObserveParentAndChildren(EntityComponent parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitiesObserver.NativeMethodInfoPtr_ObserveParentAndChildren_Public_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00018CD8 File Offset: 0x00016ED8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1110899, RefRangeEnd = 1110902, XrefRangeStart = 1110855, XrefRangeEnd = 1110899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitiesObserver.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00018D0C File Offset: 0x00016F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110902, XrefRangeEnd = 1110919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void initParentChildCollections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitiesObserver.NativeMethodInfoPtr_initParentChildCollections_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00018D40 File Offset: 0x00016F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110919, XrefRangeEnd = 1110923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNotifier(IAmDirty observer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(observer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitiesObserver.NativeMethodInfoPtr_AddNotifier_Public_Void_IAmDirty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00018D84 File Offset: 0x00016F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110923, XrefRangeEnd = 1110927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveNotifier(IAmDirty observer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(observer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitiesObserver.NativeMethodInfoPtr_RemoveNotifier_Public_Void_IAmDirty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00018DC8 File Offset: 0x00016FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110927, XrefRangeEnd = 1110929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitiesObserver.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x00018DFC File Offset: 0x00016FFC
		// (set) Token: 0x060004BF RID: 1215 RVA: 0x00018E3C File Offset: 0x0001703C
		public unsafe virtual LinkedListNode<IAmDirty> DirtyNode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitiesObserver.NativeMethodInfoPtr_get_DirtyNode_Public_Virtual_Final_New_get_LinkedListNode_1_IAmDirty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LinkedListNode<IAmDirty>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitiesObserver.NativeMethodInfoPtr_set_DirtyNode_Private_set_Void_LinkedListNode_1_IAmDirty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00018E80 File Offset: 0x00017080
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1110985, RefRangeEnd = 1110988, XrefRangeStart = 1110929, XrefRangeEnd = 1110985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updateChildren()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitiesObserver.NativeMethodInfoPtr_updateChildren_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00018EB4 File Offset: 0x000170B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1111006, RefRangeEnd = 1111007, XrefRangeStart = 1110988, XrefRangeEnd = 1111006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void notifyObservers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitiesObserver.NativeMethodInfoPtr_notifyObservers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00018EE8 File Offset: 0x000170E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1111007, XrefRangeEnd = 1111010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntitiesObserver.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x000045DB File Offset: 0x000027DB
		public EntitiesObserver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x00018F2C File Offset: 0x0001712C
		// (set) Token: 0x060004C5 RID: 1221 RVA: 0x000045E4 File Offset: 0x000027E4
		public unsafe HashSet<EntityComponent> observedDatum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesObserver.NativeFieldInfoPtr_observedDatum);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesObserver.NativeFieldInfoPtr_observedDatum), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x00018F5C File Offset: 0x0001715C
		// (set) Token: 0x060004C7 RID: 1223 RVA: 0x00004603 File Offset: 0x00002803
		public unsafe HashSet<EntityComponent> parents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesObserver.NativeFieldInfoPtr_parents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesObserver.NativeFieldInfoPtr_parents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x00018F8C File Offset: 0x0001718C
		// (set) Token: 0x060004C9 RID: 1225 RVA: 0x00004622 File Offset: 0x00002822
		public unsafe HashSet<EntityComponent> children
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesObserver.NativeFieldInfoPtr_children);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesObserver.NativeFieldInfoPtr_children), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x00018FBC File Offset: 0x000171BC
		// (set) Token: 0x060004CB RID: 1227 RVA: 0x00004641 File Offset: 0x00002841
		public unsafe HashSet<EntityComponent> children2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesObserver.NativeFieldInfoPtr_children2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<EntityComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesObserver.NativeFieldInfoPtr_children2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x00018FEC File Offset: 0x000171EC
		// (set) Token: 0x060004CD RID: 1229 RVA: 0x00004660 File Offset: 0x00002860
		public unsafe HashSet<IAmDirty> notifiers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesObserver.NativeFieldInfoPtr_notifiers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<IAmDirty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesObserver.NativeFieldInfoPtr_notifiers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x0001901C File Offset: 0x0001721C
		// (set) Token: 0x060004CF RID: 1231 RVA: 0x0000467F File Offset: 0x0000287F
		public unsafe UpdateManager um
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesObserver.NativeFieldInfoPtr_um);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesObserver.NativeFieldInfoPtr_um), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x0001904C File Offset: 0x0001724C
		// (set) Token: 0x060004D1 RID: 1233 RVA: 0x0000469E File Offset: 0x0000289E
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesObserver.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesObserver.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x00019074 File Offset: 0x00017274
		// (set) Token: 0x060004D3 RID: 1235 RVA: 0x000046BD File Offset: 0x000028BD
		public unsafe LinkedListNode<IAmDirty> dirtyNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesObserver.NativeFieldInfoPtr_dirtyNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedListNode<IAmDirty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesObserver.NativeFieldInfoPtr_dirtyNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeFieldInfoPtr_observedDatum;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeFieldInfoPtr_parents;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeFieldInfoPtr_children;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeFieldInfoPtr_children2;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeFieldInfoPtr_notifiers;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeFieldInfoPtr_um;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeFieldInfoPtr_dirtyNode;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeMethodInfoPtr_ObserveEntity_Public_Void_EntityComponent_0;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeMethodInfoPtr_MarkDirty_Public_Void_0;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeMethodInfoPtr_UnobserveEntity_Public_Void_EntityComponent_0;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeMethodInfoPtr_ObserveParentAndChildren_Public_Void_EntityComponent_0;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeMethodInfoPtr_initParentChildCollections_Private_Void_0;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeMethodInfoPtr_AddNotifier_Public_Void_IAmDirty_0;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeMethodInfoPtr_RemoveNotifier_Public_Void_IAmDirty_0;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Final_New_Void_0;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeMethodInfoPtr_get_DirtyNode_Public_Virtual_Final_New_get_LinkedListNode_1_IAmDirty_0;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeMethodInfoPtr_set_DirtyNode_Private_set_Void_LinkedListNode_1_IAmDirty_0;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeMethodInfoPtr_updateChildren_Private_Void_0;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeMethodInfoPtr_notifyObservers_Private_Void_0;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
