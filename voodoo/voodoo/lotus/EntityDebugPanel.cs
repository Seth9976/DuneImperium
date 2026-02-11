using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace lotus
{
	// Token: 0x0200004B RID: 75
	public class EntityDebugPanel : MonoBehaviour
	{
		// Token: 0x0600048D RID: 1165 RVA: 0x0001817C File Offset: 0x0001637C
		// Note: this type is marked as 'beforefieldinit'.
		static EntityDebugPanel()
		{
			Il2CppClassPointerStore<EntityDebugPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "EntityDebugPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityDebugPanel>.NativeClassPtr);
			EntityDebugPanel.NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityDebugPanel>.NativeClassPtr, "<Instance>k__BackingField");
			EntityDebugPanel.NativeFieldInfoPtr_debugSelecitonLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityDebugPanel>.NativeClassPtr, "debugSelecitonLayer");
			EntityDebugPanel.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityDebugPanel>.NativeClassPtr, "text");
			EntityDebugPanel.NativeFieldInfoPtr_debugEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityDebugPanel>.NativeClassPtr, "debugEntity");
			EntityDebugPanel.NativeFieldInfoPtr_cachedInputPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityDebugPanel>.NativeClassPtr, "cachedInputPosition");
			EntityDebugPanel.NativeMethodInfoPtr_get_Instance_Public_Static_get_EntityDebugPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDebugPanel>.NativeClassPtr, 100663835);
			EntityDebugPanel.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_EntityDebugPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDebugPanel>.NativeClassPtr, 100663836);
			EntityDebugPanel.NativeMethodInfoPtr_get_DebugEntity_Public_get_EntityDebugInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDebugPanel>.NativeClassPtr, 100663837);
			EntityDebugPanel.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDebugPanel>.NativeClassPtr, 100663838);
			EntityDebugPanel.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDebugPanel>.NativeClassPtr, 100663839);
			EntityDebugPanel.NativeMethodInfoPtr_SetDebugEntity_Public_Void_EntityDebugInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDebugPanel>.NativeClassPtr, 100663840);
			EntityDebugPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityDebugPanel>.NativeClassPtr, 100663841);
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x0001829C File Offset: 0x0001649C
		// (set) Token: 0x0600048F RID: 1167 RVA: 0x000182D0 File Offset: 0x000164D0
		public unsafe static EntityDebugPanel Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110482, XrefRangeEnd = 1110484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityDebugPanel.NativeMethodInfoPtr_get_Instance_Public_Static_get_EntityDebugPanel_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityDebugPanel>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110484, XrefRangeEnd = 1110488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityDebugPanel.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_EntityDebugPanel_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x00018308 File Offset: 0x00016508
		public unsafe EntityDebugInfo DebugEntity
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityDebugPanel.NativeMethodInfoPtr_get_DebugEntity_Public_get_EntityDebugInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityDebugInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00018348 File Offset: 0x00016548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110488, XrefRangeEnd = 1110507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityDebugPanel.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x0001837C File Offset: 0x0001657C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110507, XrefRangeEnd = 1110601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityDebugPanel.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x000183B0 File Offset: 0x000165B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110601, XrefRangeEnd = 1110614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDebugEntity(EntityDebugInfo debugEntity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(debugEntity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityDebugPanel.NativeMethodInfoPtr_SetDebugEntity_Public_Void_EntityDebugInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x000183F4 File Offset: 0x000165F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110614, XrefRangeEnd = 1110621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityDebugPanel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityDebugPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityDebugPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x0000450E File Offset: 0x0000270E
		public EntityDebugPanel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x00018430 File Offset: 0x00016630
		// (set) Token: 0x06000497 RID: 1175 RVA: 0x00004517 File Offset: 0x00002717
		public unsafe static EntityDebugPanel _Instance_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityDebugPanel.NativeFieldInfoPtr__Instance_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityDebugPanel>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityDebugPanel.NativeFieldInfoPtr__Instance_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x00018458 File Offset: 0x00016658
		// (set) Token: 0x06000499 RID: 1177 RVA: 0x00004529 File Offset: 0x00002729
		public unsafe string debugSelecitonLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityDebugPanel.NativeFieldInfoPtr_debugSelecitonLayer);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityDebugPanel.NativeFieldInfoPtr_debugSelecitonLayer), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x00018480 File Offset: 0x00016680
		// (set) Token: 0x0600049B RID: 1179 RVA: 0x00004548 File Offset: 0x00002748
		public unsafe Text text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityDebugPanel.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityDebugPanel.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x000184B0 File Offset: 0x000166B0
		// (set) Token: 0x0600049D RID: 1181 RVA: 0x00004567 File Offset: 0x00002767
		public unsafe EntityDebugInfo debugEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityDebugPanel.NativeFieldInfoPtr_debugEntity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityDebugInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityDebugPanel.NativeFieldInfoPtr_debugEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x000184E0 File Offset: 0x000166E0
		// (set) Token: 0x0600049F RID: 1183 RVA: 0x00004586 File Offset: 0x00002786
		public unsafe Vector2 cachedInputPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityDebugPanel.NativeFieldInfoPtr_cachedInputPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityDebugPanel.NativeFieldInfoPtr_cachedInputPosition)) = value;
			}
		}

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeFieldInfoPtr_debugSelecitonLayer;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeFieldInfoPtr_debugEntity;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeFieldInfoPtr_cachedInputPosition;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_EntityDebugPanel_0;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_EntityDebugPanel_0;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeMethodInfoPtr_get_DebugEntity_Public_get_EntityDebugInfo_0;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeMethodInfoPtr_SetDebugEntity_Public_Void_EntityDebugInfo_0;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
