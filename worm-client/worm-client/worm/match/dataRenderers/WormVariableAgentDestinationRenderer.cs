using System;
using boardgames.attributes;
using boardgames.match.behaviours;
using Canis.attributes;
using Canis.utils.ids;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;
using UnityEngine;
using worm.canis.data.enums;

namespace worm.match.dataRenderers
{
	// Token: 0x02000171 RID: 369
	public class WormVariableAgentDestinationRenderer : AttributeView
	{
		// Token: 0x0600106A RID: 4202 RVA: 0x000494AC File Offset: 0x000476AC
		// Note: this type is marked as 'beforefieldinit'.
		static WormVariableAgentDestinationRenderer()
		{
			Il2CppClassPointerStore<WormVariableAgentDestinationRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormVariableAgentDestinationRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer>.NativeClassPtr);
			WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer>.NativeClassPtr, "list");
			WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_iconRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer>.NativeClassPtr, "iconRoot");
			WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_HighlightParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer>.NativeClassPtr, "HighlightParam");
			WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_ShowConditionalParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer>.NativeClassPtr, "ShowConditionalParam");
			WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_EnvoyDispatchedIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer>.NativeClassPtr, "EnvoyDispatchedIcons");
			WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_entitiesProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer>.NativeClassPtr, "entitiesProvider");
			WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer>.NativeClassPtr, "entity");
			WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_cachedEntityParentID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer>.NativeClassPtr, "cachedEntityParentID");
			WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_entityParentVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer>.NativeClassPtr, "entityParentVersion");
			WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_entityInfiltrateIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer>.NativeClassPtr, "entityInfiltrateIcons");
			WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_entityConditionalIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer>.NativeClassPtr, "entityConditionalIcons");
			WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_entityEnvoyDispatched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer>.NativeClassPtr, "entityEnvoyDispatched");
			WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_localPlayerEnvoyDispatched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer>.NativeClassPtr, "localPlayerEnvoyDispatched");
			WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_localPlayerTurnType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer>.NativeClassPtr, "localPlayerTurnType");
			WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_conditionalIconRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer>.NativeClassPtr, "conditionalIconRenderer");
			WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_spawnedIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer>.NativeClassPtr, "spawnedIcons");
			WormVariableAgentDestinationRenderer.NativeMethodInfoPtr_get_Model_Private_get_IAttribute_1_List_1_AgentIcons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer>.NativeClassPtr, 100665511);
			WormVariableAgentDestinationRenderer.NativeMethodInfoPtr_get_currentModelVersion_Protected_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer>.NativeClassPtr, 100665512);
			WormVariableAgentDestinationRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer>.NativeClassPtr, 100665513);
			WormVariableAgentDestinationRenderer.NativeMethodInfoPtr_Init_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer>.NativeClassPtr, 100665514);
			WormVariableAgentDestinationRenderer.NativeMethodInfoPtr_OnViewChanged_Protected_Virtual_Void_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer>.NativeClassPtr, 100665515);
			WormVariableAgentDestinationRenderer.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer>.NativeClassPtr, 100665516);
			WormVariableAgentDestinationRenderer.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer>.NativeClassPtr, 100665517);
			WormVariableAgentDestinationRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer>.NativeClassPtr, 100665518);
			WormVariableAgentDestinationRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer>.NativeClassPtr, 100665519);
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x0600106B RID: 4203 RVA: 0x000496D0 File Offset: 0x000478D0
		public new unsafe IAttribute<List<AgentIcons>> Model
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 709473, RefRangeEnd = 709474, XrefRangeStart = 709470, XrefRangeEnd = 709473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.NativeMethodInfoPtr_get_Model_Private_get_IAttribute_1_List_1_AgentIcons_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute<List<AgentIcons>>>(intPtr3) : null;
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x0600106C RID: 4204 RVA: 0x00049710 File Offset: 0x00047910
		public unsafe override ulong currentModelVersion
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709474, XrefRangeEnd = 709492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormVariableAgentDestinationRenderer.NativeMethodInfoPtr_get_currentModelVersion_Protected_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x00049758 File Offset: 0x00047958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709492, XrefRangeEnd = 709506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormVariableAgentDestinationRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x00049794 File Offset: 0x00047994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709506, XrefRangeEnd = 709511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.NativeMethodInfoPtr_Init_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x000497D4 File Offset: 0x000479D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709511, XrefRangeEnd = 709536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnViewChanged(IHasAttributes newView)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newView);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormVariableAgentDestinationRenderer.NativeMethodInfoPtr_OnViewChanged_Protected_Virtual_Void_IHasAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x00049824 File Offset: 0x00047A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709536, XrefRangeEnd = 709561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormVariableAgentDestinationRenderer.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x00049860 File Offset: 0x00047A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709561, XrefRangeEnd = 709567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormVariableAgentDestinationRenderer.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x0004989C File Offset: 0x00047A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709567, XrefRangeEnd = 709747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormVariableAgentDestinationRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x000498D8 File Offset: 0x00047AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709747, XrefRangeEnd = 709762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormVariableAgentDestinationRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x0000AA27 File Offset: 0x00008C27
		public WormVariableAgentDestinationRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06001075 RID: 4213 RVA: 0x00049914 File Offset: 0x00047B14
		// (set) Token: 0x06001076 RID: 4214 RVA: 0x0000AA30 File Offset: 0x00008C30
		public unsafe Il2CppReferenceArray<WormVariableAgentDestinationRenderer.ObjectIconPair> list
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_list);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WormVariableAgentDestinationRenderer.ObjectIconPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06001077 RID: 4215 RVA: 0x00049944 File Offset: 0x00047B44
		// (set) Token: 0x06001078 RID: 4216 RVA: 0x0000AA4F File Offset: 0x00008C4F
		public unsafe Transform iconRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_iconRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_iconRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06001079 RID: 4217 RVA: 0x00049974 File Offset: 0x00047B74
		// (set) Token: 0x0600107A RID: 4218 RVA: 0x0000AA6E File Offset: 0x00008C6E
		public unsafe static int HighlightParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_HighlightParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_HighlightParam, (void*)(&value));
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x0600107B RID: 4219 RVA: 0x00049990 File Offset: 0x00047B90
		// (set) Token: 0x0600107C RID: 4220 RVA: 0x0000AA7C File Offset: 0x00008C7C
		public unsafe static int ShowConditionalParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_ShowConditionalParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_ShowConditionalParam, (void*)(&value));
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x0600107D RID: 4221 RVA: 0x000499AC File Offset: 0x00047BAC
		// (set) Token: 0x0600107E RID: 4222 RVA: 0x0000AA8A File Offset: 0x00008C8A
		public unsafe static IReadOnlyList<AgentIcons> EnvoyDispatchedIcons
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_EnvoyDispatchedIcons, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<AgentIcons>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_EnvoyDispatchedIcons, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x0600107F RID: 4223 RVA: 0x000499D4 File Offset: 0x00047BD4
		// (set) Token: 0x06001080 RID: 4224 RVA: 0x0000AA9C File Offset: 0x00008C9C
		public unsafe DBGEntitiesProvider entitiesProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_entitiesProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_entitiesProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06001081 RID: 4225 RVA: 0x00049A04 File Offset: 0x00047C04
		// (set) Token: 0x06001082 RID: 4226 RVA: 0x0000AABB File Offset: 0x00008CBB
		public unsafe EntityComponent entity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_entity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06001083 RID: 4227 RVA: 0x00049A34 File Offset: 0x00047C34
		// (set) Token: 0x06001084 RID: 4228 RVA: 0x0000AADA File Offset: 0x00008CDA
		public unsafe EntityID cachedEntityParentID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_cachedEntityParentID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_cachedEntityParentID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06001085 RID: 4229 RVA: 0x00049A64 File Offset: 0x00047C64
		// (set) Token: 0x06001086 RID: 4230 RVA: 0x0000AAF9 File Offset: 0x00008CF9
		public unsafe ulong entityParentVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_entityParentVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_entityParentVersion)) = value;
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06001087 RID: 4231 RVA: 0x00049A8C File Offset: 0x00047C8C
		// (set) Token: 0x06001088 RID: 4232 RVA: 0x0000AB14 File Offset: 0x00008D14
		public unsafe IAttribute<List<AgentIcons>> entityInfiltrateIcons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_entityInfiltrateIcons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<List<AgentIcons>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_entityInfiltrateIcons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06001089 RID: 4233 RVA: 0x00049ABC File Offset: 0x00047CBC
		// (set) Token: 0x0600108A RID: 4234 RVA: 0x0000AB33 File Offset: 0x00008D33
		public unsafe IAttribute<List<AgentIcons>> entityConditionalIcons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_entityConditionalIcons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<List<AgentIcons>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_entityConditionalIcons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x0600108B RID: 4235 RVA: 0x00049AEC File Offset: 0x00047CEC
		// (set) Token: 0x0600108C RID: 4236 RVA: 0x0000AB52 File Offset: 0x00008D52
		public unsafe IAttribute<Nullable<bool>> entityEnvoyDispatched
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_entityEnvoyDispatched);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_entityEnvoyDispatched), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x0600108D RID: 4237 RVA: 0x00049B1C File Offset: 0x00047D1C
		// (set) Token: 0x0600108E RID: 4238 RVA: 0x0000AB71 File Offset: 0x00008D71
		public unsafe IAttribute<Nullable<bool>> localPlayerEnvoyDispatched
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_localPlayerEnvoyDispatched);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_localPlayerEnvoyDispatched), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x0600108F RID: 4239 RVA: 0x00049B4C File Offset: 0x00047D4C
		// (set) Token: 0x06001090 RID: 4240 RVA: 0x0000AB90 File Offset: 0x00008D90
		public unsafe IAttribute<Nullable<PlayerTurnTypes>> localPlayerTurnType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_localPlayerTurnType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<PlayerTurnTypes>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_localPlayerTurnType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06001091 RID: 4241 RVA: 0x00049B7C File Offset: 0x00047D7C
		// (set) Token: 0x06001092 RID: 4242 RVA: 0x0000ABAF File Offset: 0x00008DAF
		public unsafe IConditionalIconRenderer conditionalIconRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_conditionalIconRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IConditionalIconRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_conditionalIconRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06001093 RID: 4243 RVA: 0x00049BAC File Offset: 0x00047DAC
		// (set) Token: 0x06001094 RID: 4244 RVA: 0x0000ABCE File Offset: 0x00008DCE
		public unsafe List<WormVariableAgentDestinationRenderer.SpawnedIcon> spawnedIcons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_spawnedIcons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormVariableAgentDestinationRenderer.SpawnedIcon>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.NativeFieldInfoPtr_spawnedIcons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400096E RID: 2414
		private static readonly IntPtr NativeFieldInfoPtr_list;

		// Token: 0x0400096F RID: 2415
		private static readonly IntPtr NativeFieldInfoPtr_iconRoot;

		// Token: 0x04000970 RID: 2416
		private static readonly IntPtr NativeFieldInfoPtr_HighlightParam;

		// Token: 0x04000971 RID: 2417
		private static readonly IntPtr NativeFieldInfoPtr_ShowConditionalParam;

		// Token: 0x04000972 RID: 2418
		private static readonly IntPtr NativeFieldInfoPtr_EnvoyDispatchedIcons;

		// Token: 0x04000973 RID: 2419
		private static readonly IntPtr NativeFieldInfoPtr_entitiesProvider;

		// Token: 0x04000974 RID: 2420
		private static readonly IntPtr NativeFieldInfoPtr_entity;

		// Token: 0x04000975 RID: 2421
		private static readonly IntPtr NativeFieldInfoPtr_cachedEntityParentID;

		// Token: 0x04000976 RID: 2422
		private static readonly IntPtr NativeFieldInfoPtr_entityParentVersion;

		// Token: 0x04000977 RID: 2423
		private static readonly IntPtr NativeFieldInfoPtr_entityInfiltrateIcons;

		// Token: 0x04000978 RID: 2424
		private static readonly IntPtr NativeFieldInfoPtr_entityConditionalIcons;

		// Token: 0x04000979 RID: 2425
		private static readonly IntPtr NativeFieldInfoPtr_entityEnvoyDispatched;

		// Token: 0x0400097A RID: 2426
		private static readonly IntPtr NativeFieldInfoPtr_localPlayerEnvoyDispatched;

		// Token: 0x0400097B RID: 2427
		private static readonly IntPtr NativeFieldInfoPtr_localPlayerTurnType;

		// Token: 0x0400097C RID: 2428
		private static readonly IntPtr NativeFieldInfoPtr_conditionalIconRenderer;

		// Token: 0x0400097D RID: 2429
		private static readonly IntPtr NativeFieldInfoPtr_spawnedIcons;

		// Token: 0x0400097E RID: 2430
		private static readonly IntPtr NativeMethodInfoPtr_get_Model_Private_get_IAttribute_1_List_1_AgentIcons_0;

		// Token: 0x0400097F RID: 2431
		private static readonly IntPtr NativeMethodInfoPtr_get_currentModelVersion_Protected_Virtual_get_UInt64_0;

		// Token: 0x04000980 RID: 2432
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x04000981 RID: 2433
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_IEnumerator_0;

		// Token: 0x04000982 RID: 2434
		private static readonly IntPtr NativeMethodInfoPtr_OnViewChanged_Protected_Virtual_Void_IHasAttributes_0;

		// Token: 0x04000983 RID: 2435
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04000984 RID: 2436
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x04000985 RID: 2437
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000986 RID: 2438
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003B0 RID: 944
		public class IconInfo : global::Il2CppSystem.Object
		{
			// Token: 0x060025F5 RID: 9717 RVA: 0x0008AA4C File Offset: 0x00088C4C
			// Note: this type is marked as 'beforefieldinit'.
			static IconInfo()
			{
				Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.IconInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer>.NativeClassPtr, "IconInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.IconInfo>.NativeClassPtr);
				WormVariableAgentDestinationRenderer.IconInfo.NativeFieldInfoPtr__Pair_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.IconInfo>.NativeClassPtr, "<Pair>k__BackingField");
				WormVariableAgentDestinationRenderer.IconInfo.NativeMethodInfoPtr__ctor_Public_Void_ObjectIconPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.IconInfo>.NativeClassPtr, 100665521);
				WormVariableAgentDestinationRenderer.IconInfo.NativeMethodInfoPtr_get_EqualityContract_Protected_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.IconInfo>.NativeClassPtr, 100665522);
				WormVariableAgentDestinationRenderer.IconInfo.NativeMethodInfoPtr_get_Pair_Public_get_ObjectIconPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.IconInfo>.NativeClassPtr, 100665523);
				WormVariableAgentDestinationRenderer.IconInfo.NativeMethodInfoPtr_set_Pair_Public_set_Void_ObjectIconPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.IconInfo>.NativeClassPtr, 100665524);
				WormVariableAgentDestinationRenderer.IconInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.IconInfo>.NativeClassPtr, 100665525);
				WormVariableAgentDestinationRenderer.IconInfo.NativeMethodInfoPtr_PrintMembers_Protected_Virtual_New_Boolean_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.IconInfo>.NativeClassPtr, 100665526);
				WormVariableAgentDestinationRenderer.IconInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_IconInfo_IconInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.IconInfo>.NativeClassPtr, 100665527);
				WormVariableAgentDestinationRenderer.IconInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_IconInfo_IconInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.IconInfo>.NativeClassPtr, 100665528);
				WormVariableAgentDestinationRenderer.IconInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.IconInfo>.NativeClassPtr, 100665529);
				WormVariableAgentDestinationRenderer.IconInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.IconInfo>.NativeClassPtr, 100665530);
				WormVariableAgentDestinationRenderer.IconInfo.NativeMethodInfoPtr_Equals_Public_Virtual_New_Boolean_IconInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.IconInfo>.NativeClassPtr, 100665531);
				WormVariableAgentDestinationRenderer.IconInfo.NativeMethodInfoPtr_Method_Public_Virtual_New_IconInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.IconInfo>.NativeClassPtr, 100665532);
				WormVariableAgentDestinationRenderer.IconInfo.NativeMethodInfoPtr__ctor_Protected_Void_IconInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.IconInfo>.NativeClassPtr, 100665533);
				WormVariableAgentDestinationRenderer.IconInfo.NativeMethodInfoPtr_Deconstruct_Public_Void_byref_ObjectIconPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.IconInfo>.NativeClassPtr, 100665534);
			}

			// Token: 0x060025F6 RID: 9718 RVA: 0x0008ABA4 File Offset: 0x00088DA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709243, XrefRangeEnd = 709245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IconInfo(WormVariableAgentDestinationRenderer.ObjectIconPair Pair)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.IconInfo>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(Pair));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.IconInfo.NativeMethodInfoPtr__ctor_Public_Void_ObjectIconPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000A97 RID: 2711
			// (get) Token: 0x060025F7 RID: 9719 RVA: 0x0008ABF4 File Offset: 0x00088DF4
			public unsafe virtual Type EqualityContract
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709245, XrefRangeEnd = 709251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormVariableAgentDestinationRenderer.IconInfo.NativeMethodInfoPtr_get_EqualityContract_Protected_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
				}
			}

			// Token: 0x17000A98 RID: 2712
			// (get) Token: 0x060025F8 RID: 9720 RVA: 0x0008AC40 File Offset: 0x00088E40
			// (set) Token: 0x060025F9 RID: 9721 RVA: 0x0008AC78 File Offset: 0x00088E78
			public unsafe WormVariableAgentDestinationRenderer.ObjectIconPair Pair
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.IconInfo.NativeMethodInfoPtr_get_Pair_Public_get_ObjectIconPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new WormVariableAgentDestinationRenderer.ObjectIconPair(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709251, XrefRangeEnd = 709252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.IconInfo.NativeMethodInfoPtr_set_Pair_Public_set_Void_ObjectIconPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060025FA RID: 9722 RVA: 0x0008ACC0 File Offset: 0x00088EC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709252, XrefRangeEnd = 709265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormVariableAgentDestinationRenderer.IconInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060025FB RID: 9723 RVA: 0x0008AD04 File Offset: 0x00088F04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709265, XrefRangeEnd = 709273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool PrintMembers(StringBuilder builder)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormVariableAgentDestinationRenderer.IconInfo.NativeMethodInfoPtr_PrintMembers_Protected_Virtual_New_Boolean_StringBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060025FC RID: 9724 RVA: 0x0008AD5C File Offset: 0x00088F5C
			[CallerCount(0)]
			public unsafe static bool operator !=(WormVariableAgentDestinationRenderer.IconInfo left, WormVariableAgentDestinationRenderer.IconInfo right)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.IconInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_IconInfo_IconInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060025FD RID: 9725 RVA: 0x0008ADB0 File Offset: 0x00088FB0
			[CallerCount(0)]
			public unsafe static bool operator ==(WormVariableAgentDestinationRenderer.IconInfo left, WormVariableAgentDestinationRenderer.IconInfo right)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.IconInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_IconInfo_IconInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060025FE RID: 9726 RVA: 0x0008AE04 File Offset: 0x00089004
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 709279, RefRangeEnd = 709282, XrefRangeStart = 709273, XrefRangeEnd = 709279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormVariableAgentDestinationRenderer.IconInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060025FF RID: 9727 RVA: 0x0008AE4C File Offset: 0x0008904C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709282, XrefRangeEnd = 709286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Equals(global::Il2CppSystem.Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormVariableAgentDestinationRenderer.IconInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002600 RID: 9728 RVA: 0x0008AEA4 File Offset: 0x000890A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709286, XrefRangeEnd = 709288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool Equals(WormVariableAgentDestinationRenderer.IconInfo other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormVariableAgentDestinationRenderer.IconInfo.NativeMethodInfoPtr_Equals_Public_Virtual_New_Boolean_IconInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002601 RID: 9729 RVA: 0x0008AEFC File Offset: 0x000890FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709288, XrefRangeEnd = 709293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual WormVariableAgentDestinationRenderer.IconInfo Method_Public_Virtual_New_IconInfo_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormVariableAgentDestinationRenderer.IconInfo.NativeMethodInfoPtr_Method_Public_Virtual_New_IconInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormVariableAgentDestinationRenderer.IconInfo>(intPtr3) : null;
			}

			// Token: 0x06002602 RID: 9730 RVA: 0x0008AF48 File Offset: 0x00089148
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709293, XrefRangeEnd = 709296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IconInfo(WormVariableAgentDestinationRenderer.IconInfo original)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.IconInfo>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.IconInfo.NativeMethodInfoPtr__ctor_Protected_Void_IconInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002603 RID: 9731 RVA: 0x0008AF94 File Offset: 0x00089194
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709296, XrefRangeEnd = 709297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Deconstruct(out WormVariableAgentDestinationRenderer.ObjectIconPair Pair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr = 0;
					ptr2 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.IconInfo.NativeMethodInfoPtr_Deconstruct_Public_Void_byref_ObjectIconPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					Pair = ((intPtr4 == 0) ? null : new WormVariableAgentDestinationRenderer.ObjectIconPair(intPtr4));
				}
			}

			// Token: 0x06002604 RID: 9732 RVA: 0x000151BC File Offset: 0x000133BC
			public IconInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A96 RID: 2710
			// (get) Token: 0x06002605 RID: 9733 RVA: 0x0008AFE8 File Offset: 0x000891E8
			// (set) Token: 0x06002606 RID: 9734 RVA: 0x000151C5 File Offset: 0x000133C5
			public WormVariableAgentDestinationRenderer.ObjectIconPair _Pair_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.IconInfo.NativeFieldInfoPtr__Pair_k__BackingField);
					return new WormVariableAgentDestinationRenderer.ObjectIconPair(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.ObjectIconPair>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.IconInfo.NativeFieldInfoPtr__Pair_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.ObjectIconPair>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040015C7 RID: 5575
			private static readonly IntPtr NativeFieldInfoPtr__Pair_k__BackingField;

			// Token: 0x040015C8 RID: 5576
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectIconPair_0;

			// Token: 0x040015C9 RID: 5577
			private static readonly IntPtr NativeMethodInfoPtr_get_EqualityContract_Protected_Virtual_New_get_Type_0;

			// Token: 0x040015CA RID: 5578
			private static readonly IntPtr NativeMethodInfoPtr_get_Pair_Public_get_ObjectIconPair_0;

			// Token: 0x040015CB RID: 5579
			private static readonly IntPtr NativeMethodInfoPtr_set_Pair_Public_set_Void_ObjectIconPair_0;

			// Token: 0x040015CC RID: 5580
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x040015CD RID: 5581
			private static readonly IntPtr NativeMethodInfoPtr_PrintMembers_Protected_Virtual_New_Boolean_StringBuilder_0;

			// Token: 0x040015CE RID: 5582
			private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_IconInfo_IconInfo_0;

			// Token: 0x040015CF RID: 5583
			private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_IconInfo_IconInfo_0;

			// Token: 0x040015D0 RID: 5584
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x040015D1 RID: 5585
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

			// Token: 0x040015D2 RID: 5586
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_New_Boolean_IconInfo_0;

			// Token: 0x040015D3 RID: 5587
			private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Virtual_New_IconInfo_0;

			// Token: 0x040015D4 RID: 5588
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_IconInfo_0;

			// Token: 0x040015D5 RID: 5589
			private static readonly IntPtr NativeMethodInfoPtr_Deconstruct_Public_Void_byref_ObjectIconPair_0;
		}

		// Token: 0x020003B1 RID: 945
		public sealed class EnvoyIconInfo : WormVariableAgentDestinationRenderer.IconInfo
		{
			// Token: 0x06002607 RID: 9735 RVA: 0x0008B018 File Offset: 0x00089218
			// Note: this type is marked as 'beforefieldinit'.
			static EnvoyIconInfo()
			{
				Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.EnvoyIconInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer>.NativeClassPtr, "EnvoyIconInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.EnvoyIconInfo>.NativeClassPtr);
				WormVariableAgentDestinationRenderer.EnvoyIconInfo.NativeMethodInfoPtr__ctor_Public_Void_ObjectIconPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.EnvoyIconInfo>.NativeClassPtr, 100665535);
				WormVariableAgentDestinationRenderer.EnvoyIconInfo.NativeMethodInfoPtr_get_EqualityContract_Protected_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.EnvoyIconInfo>.NativeClassPtr, 100665536);
				WormVariableAgentDestinationRenderer.EnvoyIconInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.EnvoyIconInfo>.NativeClassPtr, 100665537);
				WormVariableAgentDestinationRenderer.EnvoyIconInfo.NativeMethodInfoPtr_PrintMembers_Protected_Virtual_Boolean_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.EnvoyIconInfo>.NativeClassPtr, 100665538);
				WormVariableAgentDestinationRenderer.EnvoyIconInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_EnvoyIconInfo_EnvoyIconInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.EnvoyIconInfo>.NativeClassPtr, 100665539);
				WormVariableAgentDestinationRenderer.EnvoyIconInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_EnvoyIconInfo_EnvoyIconInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.EnvoyIconInfo>.NativeClassPtr, 100665540);
				WormVariableAgentDestinationRenderer.EnvoyIconInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.EnvoyIconInfo>.NativeClassPtr, 100665541);
				WormVariableAgentDestinationRenderer.EnvoyIconInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.EnvoyIconInfo>.NativeClassPtr, 100665542);
				WormVariableAgentDestinationRenderer.EnvoyIconInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Final_Boolean_IconInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.EnvoyIconInfo>.NativeClassPtr, 100665543);
				WormVariableAgentDestinationRenderer.EnvoyIconInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_EnvoyIconInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.EnvoyIconInfo>.NativeClassPtr, 100665544);
				WormVariableAgentDestinationRenderer.EnvoyIconInfo.NativeMethodInfoPtr_Method_Public_Virtual_IconInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.EnvoyIconInfo>.NativeClassPtr, 100665545);
				WormVariableAgentDestinationRenderer.EnvoyIconInfo.NativeMethodInfoPtr__ctor_Private_Void_EnvoyIconInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.EnvoyIconInfo>.NativeClassPtr, 100665546);
				WormVariableAgentDestinationRenderer.EnvoyIconInfo.NativeMethodInfoPtr_Deconstruct_Public_Void_byref_ObjectIconPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.EnvoyIconInfo>.NativeClassPtr, 100665547);
			}

			// Token: 0x06002608 RID: 9736 RVA: 0x0008B148 File Offset: 0x00089348
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EnvoyIconInfo(WormVariableAgentDestinationRenderer.ObjectIconPair Pair)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.EnvoyIconInfo>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(Pair));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.EnvoyIconInfo.NativeMethodInfoPtr__ctor_Public_Void_ObjectIconPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000A99 RID: 2713
			// (get) Token: 0x06002609 RID: 9737 RVA: 0x0008B198 File Offset: 0x00089398
			public unsafe override Type EqualityContract
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709297, XrefRangeEnd = 709303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.EnvoyIconInfo.NativeMethodInfoPtr_get_EqualityContract_Protected_Virtual_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
				}
			}

			// Token: 0x0600260A RID: 9738 RVA: 0x0008B1D8 File Offset: 0x000893D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709303, XrefRangeEnd = 709316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.EnvoyIconInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600260B RID: 9739 RVA: 0x0008B210 File Offset: 0x00089410
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool PrintMembers(StringBuilder builder)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.EnvoyIconInfo.NativeMethodInfoPtr_PrintMembers_Protected_Virtual_Boolean_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600260C RID: 9740 RVA: 0x0008B260 File Offset: 0x00089460
			[CallerCount(0)]
			public unsafe static bool operator !=(WormVariableAgentDestinationRenderer.EnvoyIconInfo left, WormVariableAgentDestinationRenderer.EnvoyIconInfo right)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.EnvoyIconInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_EnvoyIconInfo_EnvoyIconInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600260D RID: 9741 RVA: 0x0008B2B4 File Offset: 0x000894B4
			[CallerCount(0)]
			public unsafe static bool operator ==(WormVariableAgentDestinationRenderer.EnvoyIconInfo left, WormVariableAgentDestinationRenderer.EnvoyIconInfo right)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.EnvoyIconInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_EnvoyIconInfo_EnvoyIconInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600260E RID: 9742 RVA: 0x0008B308 File Offset: 0x00089508
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709316, XrefRangeEnd = 709317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.EnvoyIconInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600260F RID: 9743 RVA: 0x0008B344 File Offset: 0x00089544
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709317, XrefRangeEnd = 709319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Equals(global::Il2CppSystem.Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.EnvoyIconInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002610 RID: 9744 RVA: 0x0008B394 File Offset: 0x00089594
			[CallerCount(0)]
			public unsafe override bool Equals(WormVariableAgentDestinationRenderer.IconInfo other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.EnvoyIconInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Final_Boolean_IconInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002611 RID: 9745 RVA: 0x0008B3E4 File Offset: 0x000895E4
			[CallerCount(0)]
			public unsafe bool Equals(WormVariableAgentDestinationRenderer.EnvoyIconInfo other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.EnvoyIconInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_EnvoyIconInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002612 RID: 9746 RVA: 0x0008B434 File Offset: 0x00089634
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709319, XrefRangeEnd = 709324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override WormVariableAgentDestinationRenderer.IconInfo Method_Public_Virtual_IconInfo_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.EnvoyIconInfo.NativeMethodInfoPtr_Method_Public_Virtual_IconInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormVariableAgentDestinationRenderer.IconInfo>(intPtr3) : null;
			}

			// Token: 0x06002613 RID: 9747 RVA: 0x0008B474 File Offset: 0x00089674
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EnvoyIconInfo(WormVariableAgentDestinationRenderer.EnvoyIconInfo original)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.EnvoyIconInfo>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.EnvoyIconInfo.NativeMethodInfoPtr__ctor_Private_Void_EnvoyIconInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002614 RID: 9748 RVA: 0x0008B4C0 File Offset: 0x000896C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public new unsafe void Deconstruct(out WormVariableAgentDestinationRenderer.ObjectIconPair Pair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr = 0;
					ptr2 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.EnvoyIconInfo.NativeMethodInfoPtr_Deconstruct_Public_Void_byref_ObjectIconPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					Pair = ((intPtr4 == 0) ? null : new WormVariableAgentDestinationRenderer.ObjectIconPair(intPtr4));
				}
			}

			// Token: 0x06002615 RID: 9749 RVA: 0x000151F3 File Offset: 0x000133F3
			public EnvoyIconInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040015D6 RID: 5590
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectIconPair_0;

			// Token: 0x040015D7 RID: 5591
			private static readonly IntPtr NativeMethodInfoPtr_get_EqualityContract_Protected_Virtual_get_Type_0;

			// Token: 0x040015D8 RID: 5592
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x040015D9 RID: 5593
			private static readonly IntPtr NativeMethodInfoPtr_PrintMembers_Protected_Virtual_Boolean_StringBuilder_0;

			// Token: 0x040015DA RID: 5594
			private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_EnvoyIconInfo_EnvoyIconInfo_0;

			// Token: 0x040015DB RID: 5595
			private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_EnvoyIconInfo_EnvoyIconInfo_0;

			// Token: 0x040015DC RID: 5596
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x040015DD RID: 5597
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

			// Token: 0x040015DE RID: 5598
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_Boolean_IconInfo_0;

			// Token: 0x040015DF RID: 5599
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_EnvoyIconInfo_0;

			// Token: 0x040015E0 RID: 5600
			private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Virtual_IconInfo_0;

			// Token: 0x040015E1 RID: 5601
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_EnvoyIconInfo_0;

			// Token: 0x040015E2 RID: 5602
			private static readonly IntPtr NativeMethodInfoPtr_Deconstruct_Public_Void_byref_ObjectIconPair_0;
		}

		// Token: 0x020003B2 RID: 946
		public sealed class InfiltrateIconInfo : WormVariableAgentDestinationRenderer.IconInfo
		{
			// Token: 0x06002616 RID: 9750 RVA: 0x0008B514 File Offset: 0x00089714
			// Note: this type is marked as 'beforefieldinit'.
			static InfiltrateIconInfo()
			{
				Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.InfiltrateIconInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer>.NativeClassPtr, "InfiltrateIconInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.InfiltrateIconInfo>.NativeClassPtr);
				WormVariableAgentDestinationRenderer.InfiltrateIconInfo.NativeMethodInfoPtr__ctor_Public_Void_ObjectIconPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.InfiltrateIconInfo>.NativeClassPtr, 100665548);
				WormVariableAgentDestinationRenderer.InfiltrateIconInfo.NativeMethodInfoPtr_get_EqualityContract_Protected_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.InfiltrateIconInfo>.NativeClassPtr, 100665549);
				WormVariableAgentDestinationRenderer.InfiltrateIconInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.InfiltrateIconInfo>.NativeClassPtr, 100665550);
				WormVariableAgentDestinationRenderer.InfiltrateIconInfo.NativeMethodInfoPtr_PrintMembers_Protected_Virtual_Boolean_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.InfiltrateIconInfo>.NativeClassPtr, 100665551);
				WormVariableAgentDestinationRenderer.InfiltrateIconInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InfiltrateIconInfo_InfiltrateIconInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.InfiltrateIconInfo>.NativeClassPtr, 100665552);
				WormVariableAgentDestinationRenderer.InfiltrateIconInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InfiltrateIconInfo_InfiltrateIconInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.InfiltrateIconInfo>.NativeClassPtr, 100665553);
				WormVariableAgentDestinationRenderer.InfiltrateIconInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.InfiltrateIconInfo>.NativeClassPtr, 100665554);
				WormVariableAgentDestinationRenderer.InfiltrateIconInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.InfiltrateIconInfo>.NativeClassPtr, 100665555);
				WormVariableAgentDestinationRenderer.InfiltrateIconInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Final_Boolean_IconInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.InfiltrateIconInfo>.NativeClassPtr, 100665556);
				WormVariableAgentDestinationRenderer.InfiltrateIconInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InfiltrateIconInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.InfiltrateIconInfo>.NativeClassPtr, 100665557);
				WormVariableAgentDestinationRenderer.InfiltrateIconInfo.NativeMethodInfoPtr_Method_Public_Virtual_IconInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.InfiltrateIconInfo>.NativeClassPtr, 100665558);
				WormVariableAgentDestinationRenderer.InfiltrateIconInfo.NativeMethodInfoPtr__ctor_Private_Void_InfiltrateIconInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.InfiltrateIconInfo>.NativeClassPtr, 100665559);
				WormVariableAgentDestinationRenderer.InfiltrateIconInfo.NativeMethodInfoPtr_Deconstruct_Public_Void_byref_ObjectIconPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.InfiltrateIconInfo>.NativeClassPtr, 100665560);
			}

			// Token: 0x06002617 RID: 9751 RVA: 0x0008B644 File Offset: 0x00089844
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InfiltrateIconInfo(WormVariableAgentDestinationRenderer.ObjectIconPair Pair)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.InfiltrateIconInfo>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(Pair));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.InfiltrateIconInfo.NativeMethodInfoPtr__ctor_Public_Void_ObjectIconPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000A9A RID: 2714
			// (get) Token: 0x06002618 RID: 9752 RVA: 0x0008B694 File Offset: 0x00089894
			public unsafe override Type EqualityContract
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709324, XrefRangeEnd = 709330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.InfiltrateIconInfo.NativeMethodInfoPtr_get_EqualityContract_Protected_Virtual_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
				}
			}

			// Token: 0x06002619 RID: 9753 RVA: 0x0008B6D4 File Offset: 0x000898D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709330, XrefRangeEnd = 709343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.InfiltrateIconInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600261A RID: 9754 RVA: 0x0008B70C File Offset: 0x0008990C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool PrintMembers(StringBuilder builder)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.InfiltrateIconInfo.NativeMethodInfoPtr_PrintMembers_Protected_Virtual_Boolean_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600261B RID: 9755 RVA: 0x0008B75C File Offset: 0x0008995C
			[CallerCount(0)]
			public unsafe static bool operator !=(WormVariableAgentDestinationRenderer.InfiltrateIconInfo left, WormVariableAgentDestinationRenderer.InfiltrateIconInfo right)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.InfiltrateIconInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InfiltrateIconInfo_InfiltrateIconInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600261C RID: 9756 RVA: 0x0008B7B0 File Offset: 0x000899B0
			[CallerCount(0)]
			public unsafe static bool operator ==(WormVariableAgentDestinationRenderer.InfiltrateIconInfo left, WormVariableAgentDestinationRenderer.InfiltrateIconInfo right)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.InfiltrateIconInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InfiltrateIconInfo_InfiltrateIconInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600261D RID: 9757 RVA: 0x0008B804 File Offset: 0x00089A04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.InfiltrateIconInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600261E RID: 9758 RVA: 0x0008B840 File Offset: 0x00089A40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709343, XrefRangeEnd = 709345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Equals(global::Il2CppSystem.Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.InfiltrateIconInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600261F RID: 9759 RVA: 0x0008B890 File Offset: 0x00089A90
			[CallerCount(0)]
			public unsafe override bool Equals(WormVariableAgentDestinationRenderer.IconInfo other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.InfiltrateIconInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Final_Boolean_IconInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002620 RID: 9760 RVA: 0x0008B8E0 File Offset: 0x00089AE0
			[CallerCount(0)]
			public unsafe bool Equals(WormVariableAgentDestinationRenderer.InfiltrateIconInfo other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.InfiltrateIconInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InfiltrateIconInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002621 RID: 9761 RVA: 0x0008B930 File Offset: 0x00089B30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709345, XrefRangeEnd = 709350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override WormVariableAgentDestinationRenderer.IconInfo Method_Public_Virtual_IconInfo_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.InfiltrateIconInfo.NativeMethodInfoPtr_Method_Public_Virtual_IconInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormVariableAgentDestinationRenderer.IconInfo>(intPtr3) : null;
			}

			// Token: 0x06002622 RID: 9762 RVA: 0x0008B970 File Offset: 0x00089B70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InfiltrateIconInfo(WormVariableAgentDestinationRenderer.InfiltrateIconInfo original)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.InfiltrateIconInfo>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.InfiltrateIconInfo.NativeMethodInfoPtr__ctor_Private_Void_InfiltrateIconInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002623 RID: 9763 RVA: 0x0008B9BC File Offset: 0x00089BBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public new unsafe void Deconstruct(out WormVariableAgentDestinationRenderer.ObjectIconPair Pair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr = 0;
					ptr2 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.InfiltrateIconInfo.NativeMethodInfoPtr_Deconstruct_Public_Void_byref_ObjectIconPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					Pair = ((intPtr4 == 0) ? null : new WormVariableAgentDestinationRenderer.ObjectIconPair(intPtr4));
				}
			}

			// Token: 0x06002624 RID: 9764 RVA: 0x000151FC File Offset: 0x000133FC
			public InfiltrateIconInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040015E3 RID: 5603
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectIconPair_0;

			// Token: 0x040015E4 RID: 5604
			private static readonly IntPtr NativeMethodInfoPtr_get_EqualityContract_Protected_Virtual_get_Type_0;

			// Token: 0x040015E5 RID: 5605
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x040015E6 RID: 5606
			private static readonly IntPtr NativeMethodInfoPtr_PrintMembers_Protected_Virtual_Boolean_StringBuilder_0;

			// Token: 0x040015E7 RID: 5607
			private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InfiltrateIconInfo_InfiltrateIconInfo_0;

			// Token: 0x040015E8 RID: 5608
			private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InfiltrateIconInfo_InfiltrateIconInfo_0;

			// Token: 0x040015E9 RID: 5609
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x040015EA RID: 5610
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

			// Token: 0x040015EB RID: 5611
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_Boolean_IconInfo_0;

			// Token: 0x040015EC RID: 5612
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InfiltrateIconInfo_0;

			// Token: 0x040015ED RID: 5613
			private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Virtual_IconInfo_0;

			// Token: 0x040015EE RID: 5614
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_InfiltrateIconInfo_0;

			// Token: 0x040015EF RID: 5615
			private static readonly IntPtr NativeMethodInfoPtr_Deconstruct_Public_Void_byref_ObjectIconPair_0;
		}

		// Token: 0x020003B3 RID: 947
		public sealed class ConditionalIconInfo : WormVariableAgentDestinationRenderer.IconInfo
		{
			// Token: 0x06002625 RID: 9765 RVA: 0x0008BA10 File Offset: 0x00089C10
			// Note: this type is marked as 'beforefieldinit'.
			static ConditionalIconInfo()
			{
				Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.ConditionalIconInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer>.NativeClassPtr, "ConditionalIconInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.ConditionalIconInfo>.NativeClassPtr);
				WormVariableAgentDestinationRenderer.ConditionalIconInfo.NativeFieldInfoPtr__ConditionalObj_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.ConditionalIconInfo>.NativeClassPtr, "<ConditionalObj>k__BackingField");
				WormVariableAgentDestinationRenderer.ConditionalIconInfo.NativeMethodInfoPtr__ctor_Public_Void_ObjectIconPair_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.ConditionalIconInfo>.NativeClassPtr, 100665561);
				WormVariableAgentDestinationRenderer.ConditionalIconInfo.NativeMethodInfoPtr_get_EqualityContract_Protected_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.ConditionalIconInfo>.NativeClassPtr, 100665562);
				WormVariableAgentDestinationRenderer.ConditionalIconInfo.NativeMethodInfoPtr_get_ConditionalObj_Public_get_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.ConditionalIconInfo>.NativeClassPtr, 100665563);
				WormVariableAgentDestinationRenderer.ConditionalIconInfo.NativeMethodInfoPtr_set_ConditionalObj_Public_set_Void_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.ConditionalIconInfo>.NativeClassPtr, 100665564);
				WormVariableAgentDestinationRenderer.ConditionalIconInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.ConditionalIconInfo>.NativeClassPtr, 100665565);
				WormVariableAgentDestinationRenderer.ConditionalIconInfo.NativeMethodInfoPtr_PrintMembers_Protected_Virtual_Boolean_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.ConditionalIconInfo>.NativeClassPtr, 100665566);
				WormVariableAgentDestinationRenderer.ConditionalIconInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ConditionalIconInfo_ConditionalIconInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.ConditionalIconInfo>.NativeClassPtr, 100665567);
				WormVariableAgentDestinationRenderer.ConditionalIconInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ConditionalIconInfo_ConditionalIconInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.ConditionalIconInfo>.NativeClassPtr, 100665568);
				WormVariableAgentDestinationRenderer.ConditionalIconInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.ConditionalIconInfo>.NativeClassPtr, 100665569);
				WormVariableAgentDestinationRenderer.ConditionalIconInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.ConditionalIconInfo>.NativeClassPtr, 100665570);
				WormVariableAgentDestinationRenderer.ConditionalIconInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Final_Boolean_IconInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.ConditionalIconInfo>.NativeClassPtr, 100665571);
				WormVariableAgentDestinationRenderer.ConditionalIconInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ConditionalIconInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.ConditionalIconInfo>.NativeClassPtr, 100665572);
				WormVariableAgentDestinationRenderer.ConditionalIconInfo.NativeMethodInfoPtr_Method_Public_Virtual_IconInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.ConditionalIconInfo>.NativeClassPtr, 100665573);
				WormVariableAgentDestinationRenderer.ConditionalIconInfo.NativeMethodInfoPtr__ctor_Private_Void_ConditionalIconInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.ConditionalIconInfo>.NativeClassPtr, 100665574);
				WormVariableAgentDestinationRenderer.ConditionalIconInfo.NativeMethodInfoPtr_Deconstruct_Public_Void_byref_ObjectIconPair_byref_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.ConditionalIconInfo>.NativeClassPtr, 100665575);
			}

			// Token: 0x06002626 RID: 9766 RVA: 0x0008BB7C File Offset: 0x00089D7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709350, XrefRangeEnd = 709353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConditionalIconInfo(WormVariableAgentDestinationRenderer.ObjectIconPair Pair, Animator ConditionalObj)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.ConditionalIconInfo>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(Pair));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ConditionalObj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.ConditionalIconInfo.NativeMethodInfoPtr__ctor_Public_Void_ObjectIconPair_Animator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A9C RID: 2716
			// (get) Token: 0x06002627 RID: 9767 RVA: 0x0008BBE0 File Offset: 0x00089DE0
			public unsafe override Type EqualityContract
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709353, XrefRangeEnd = 709359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.ConditionalIconInfo.NativeMethodInfoPtr_get_EqualityContract_Protected_Virtual_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
				}
			}

			// Token: 0x17000A9D RID: 2717
			// (get) Token: 0x06002628 RID: 9768 RVA: 0x0008BC20 File Offset: 0x00089E20
			// (set) Token: 0x06002629 RID: 9769 RVA: 0x0008BC60 File Offset: 0x00089E60
			public unsafe Animator ConditionalObj
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.ConditionalIconInfo.NativeMethodInfoPtr_get_ConditionalObj_Public_get_Animator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr3) : null;
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.ConditionalIconInfo.NativeMethodInfoPtr_set_ConditionalObj_Public_set_Void_Animator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x0600262A RID: 9770 RVA: 0x0008BCA4 File Offset: 0x00089EA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709359, XrefRangeEnd = 709372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.ConditionalIconInfo.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600262B RID: 9771 RVA: 0x0008BCDC File Offset: 0x00089EDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709372, XrefRangeEnd = 709387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool PrintMembers(StringBuilder builder)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.ConditionalIconInfo.NativeMethodInfoPtr_PrintMembers_Protected_Virtual_Boolean_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600262C RID: 9772 RVA: 0x0008BD2C File Offset: 0x00089F2C
			[CallerCount(0)]
			public unsafe static bool operator !=(WormVariableAgentDestinationRenderer.ConditionalIconInfo left, WormVariableAgentDestinationRenderer.ConditionalIconInfo right)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.ConditionalIconInfo.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ConditionalIconInfo_ConditionalIconInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600262D RID: 9773 RVA: 0x0008BD80 File Offset: 0x00089F80
			[CallerCount(0)]
			public unsafe static bool operator ==(WormVariableAgentDestinationRenderer.ConditionalIconInfo left, WormVariableAgentDestinationRenderer.ConditionalIconInfo right)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.ConditionalIconInfo.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ConditionalIconInfo_ConditionalIconInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600262E RID: 9774 RVA: 0x0008BDD4 File Offset: 0x00089FD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709387, XrefRangeEnd = 709391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.ConditionalIconInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600262F RID: 9775 RVA: 0x0008BE10 File Offset: 0x0008A010
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709391, XrefRangeEnd = 709394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Equals(global::Il2CppSystem.Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.ConditionalIconInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002630 RID: 9776 RVA: 0x0008BE60 File Offset: 0x0008A060
			[CallerCount(0)]
			public unsafe override bool Equals(WormVariableAgentDestinationRenderer.IconInfo other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.ConditionalIconInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Final_Boolean_IconInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002631 RID: 9777 RVA: 0x0008BEB0 File Offset: 0x0008A0B0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 709395, RefRangeEnd = 709396, XrefRangeStart = 709394, XrefRangeEnd = 709395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Equals(WormVariableAgentDestinationRenderer.ConditionalIconInfo other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.ConditionalIconInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ConditionalIconInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002632 RID: 9778 RVA: 0x0008BF00 File Offset: 0x0008A100
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709396, XrefRangeEnd = 709402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override WormVariableAgentDestinationRenderer.IconInfo Method_Public_Virtual_IconInfo_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.ConditionalIconInfo.NativeMethodInfoPtr_Method_Public_Virtual_IconInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormVariableAgentDestinationRenderer.IconInfo>(intPtr3) : null;
			}

			// Token: 0x06002633 RID: 9779 RVA: 0x0008BF40 File Offset: 0x0008A140
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709402, XrefRangeEnd = 709406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConditionalIconInfo(WormVariableAgentDestinationRenderer.ConditionalIconInfo original)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.ConditionalIconInfo>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.ConditionalIconInfo.NativeMethodInfoPtr__ctor_Private_Void_ConditionalIconInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002634 RID: 9780 RVA: 0x0008BF8C File Offset: 0x0008A18C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709406, XrefRangeEnd = 709408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Deconstruct(out WormVariableAgentDestinationRenderer.ObjectIconPair Pair, out Animator ConditionalObj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = 0;
					ptr2 = &intPtr;
				}
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = 0;
				ptr3 = &intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.ConditionalIconInfo.NativeMethodInfoPtr_Deconstruct_Public_Void_byref_ObjectIconPair_byref_Animator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				IntPtr intPtr5 = intPtr;
				Pair = ((intPtr5 == 0) ? null : new WormVariableAgentDestinationRenderer.ObjectIconPair(intPtr5));
				IntPtr intPtr6 = intPtr2;
				ConditionalObj = ((intPtr6 == 0) ? null : new Animator(intPtr6));
			}

			// Token: 0x06002635 RID: 9781 RVA: 0x00015205 File Offset: 0x00013405
			public ConditionalIconInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A9B RID: 2715
			// (get) Token: 0x06002636 RID: 9782 RVA: 0x0008C000 File Offset: 0x0008A200
			// (set) Token: 0x06002637 RID: 9783 RVA: 0x0001520E File Offset: 0x0001340E
			public unsafe Animator _ConditionalObj_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.ConditionalIconInfo.NativeFieldInfoPtr__ConditionalObj_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.ConditionalIconInfo.NativeFieldInfoPtr__ConditionalObj_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015F0 RID: 5616
			private static readonly IntPtr NativeFieldInfoPtr__ConditionalObj_k__BackingField;

			// Token: 0x040015F1 RID: 5617
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectIconPair_Animator_0;

			// Token: 0x040015F2 RID: 5618
			private static readonly IntPtr NativeMethodInfoPtr_get_EqualityContract_Protected_Virtual_get_Type_0;

			// Token: 0x040015F3 RID: 5619
			private static readonly IntPtr NativeMethodInfoPtr_get_ConditionalObj_Public_get_Animator_0;

			// Token: 0x040015F4 RID: 5620
			private static readonly IntPtr NativeMethodInfoPtr_set_ConditionalObj_Public_set_Void_Animator_0;

			// Token: 0x040015F5 RID: 5621
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x040015F6 RID: 5622
			private static readonly IntPtr NativeMethodInfoPtr_PrintMembers_Protected_Virtual_Boolean_StringBuilder_0;

			// Token: 0x040015F7 RID: 5623
			private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ConditionalIconInfo_ConditionalIconInfo_0;

			// Token: 0x040015F8 RID: 5624
			private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ConditionalIconInfo_ConditionalIconInfo_0;

			// Token: 0x040015F9 RID: 5625
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x040015FA RID: 5626
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

			// Token: 0x040015FB RID: 5627
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_Boolean_IconInfo_0;

			// Token: 0x040015FC RID: 5628
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ConditionalIconInfo_0;

			// Token: 0x040015FD RID: 5629
			private static readonly IntPtr NativeMethodInfoPtr_Method_Public_Virtual_IconInfo_0;

			// Token: 0x040015FE RID: 5630
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_ConditionalIconInfo_0;

			// Token: 0x040015FF RID: 5631
			private static readonly IntPtr NativeMethodInfoPtr_Deconstruct_Public_Void_byref_ObjectIconPair_byref_Animator_0;
		}

		// Token: 0x020003B4 RID: 948
		public sealed class SpawnedIcon : ValueType
		{
			// Token: 0x06002638 RID: 9784 RVA: 0x0008C030 File Offset: 0x0008A230
			// Note: this type is marked as 'beforefieldinit'.
			static SpawnedIcon()
			{
				Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.SpawnedIcon>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer>.NativeClassPtr, "SpawnedIcon");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.SpawnedIcon>.NativeClassPtr);
				WormVariableAgentDestinationRenderer.SpawnedIcon.NativeFieldInfoPtr__Obj_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.SpawnedIcon>.NativeClassPtr, "<Obj>k__BackingField");
				WormVariableAgentDestinationRenderer.SpawnedIcon.NativeFieldInfoPtr__Info_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.SpawnedIcon>.NativeClassPtr, "<Info>k__BackingField");
				WormVariableAgentDestinationRenderer.SpawnedIcon.NativeMethodInfoPtr__ctor_Public_Void_GameObject_IconInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.SpawnedIcon>.NativeClassPtr, 100665576);
				WormVariableAgentDestinationRenderer.SpawnedIcon.NativeMethodInfoPtr_get_Obj_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.SpawnedIcon>.NativeClassPtr, 100665577);
				WormVariableAgentDestinationRenderer.SpawnedIcon.NativeMethodInfoPtr_set_Obj_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.SpawnedIcon>.NativeClassPtr, 100665578);
				WormVariableAgentDestinationRenderer.SpawnedIcon.NativeMethodInfoPtr_get_Info_Public_get_IconInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.SpawnedIcon>.NativeClassPtr, 100665579);
				WormVariableAgentDestinationRenderer.SpawnedIcon.NativeMethodInfoPtr_set_Info_Public_set_Void_IconInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.SpawnedIcon>.NativeClassPtr, 100665580);
				WormVariableAgentDestinationRenderer.SpawnedIcon.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.SpawnedIcon>.NativeClassPtr, 100665581);
				WormVariableAgentDestinationRenderer.SpawnedIcon.NativeMethodInfoPtr_PrintMembers_Private_Boolean_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.SpawnedIcon>.NativeClassPtr, 100665582);
				WormVariableAgentDestinationRenderer.SpawnedIcon.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SpawnedIcon_SpawnedIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.SpawnedIcon>.NativeClassPtr, 100665583);
				WormVariableAgentDestinationRenderer.SpawnedIcon.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SpawnedIcon_SpawnedIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.SpawnedIcon>.NativeClassPtr, 100665584);
				WormVariableAgentDestinationRenderer.SpawnedIcon.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.SpawnedIcon>.NativeClassPtr, 100665585);
				WormVariableAgentDestinationRenderer.SpawnedIcon.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.SpawnedIcon>.NativeClassPtr, 100665586);
				WormVariableAgentDestinationRenderer.SpawnedIcon.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SpawnedIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.SpawnedIcon>.NativeClassPtr, 100665587);
				WormVariableAgentDestinationRenderer.SpawnedIcon.NativeMethodInfoPtr_Deconstruct_Public_Void_byref_GameObject_byref_IconInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.SpawnedIcon>.NativeClassPtr, 100665588);
			}

			// Token: 0x06002639 RID: 9785 RVA: 0x0008C188 File Offset: 0x0008A388
			[CallerCount(238)]
			[CachedScanResults(RefRangeStart = 342357, RefRangeEnd = 342595, XrefRangeStart = 342357, XrefRangeEnd = 342595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SpawnedIcon(GameObject Obj, WormVariableAgentDestinationRenderer.IconInfo Info)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.SpawnedIcon>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(Obj);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(Info);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.SpawnedIcon.NativeMethodInfoPtr__ctor_Public_Void_GameObject_IconInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000AA0 RID: 2720
			// (get) Token: 0x0600263A RID: 9786 RVA: 0x0008C1EC File Offset: 0x0008A3EC
			// (set) Token: 0x0600263B RID: 9787 RVA: 0x0008C230 File Offset: 0x0008A430
			public unsafe GameObject Obj
			{
				[CallerCount(99)]
				[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.SpawnedIcon.NativeMethodInfoPtr_get_Obj_Public_get_GameObject_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
				}
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.SpawnedIcon.NativeMethodInfoPtr_set_Obj_Public_set_Void_GameObject_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000AA1 RID: 2721
			// (get) Token: 0x0600263C RID: 9788 RVA: 0x0008C278 File Offset: 0x0008A478
			// (set) Token: 0x0600263D RID: 9789 RVA: 0x0008C2BC File Offset: 0x0008A4BC
			public unsafe WormVariableAgentDestinationRenderer.IconInfo Info
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.SpawnedIcon.NativeMethodInfoPtr_get_Info_Public_get_IconInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormVariableAgentDestinationRenderer.IconInfo>(intPtr3) : null;
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 315685, RefRangeEnd = 315686, XrefRangeStart = 315685, XrefRangeEnd = 315686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.SpawnedIcon.NativeMethodInfoPtr_set_Info_Public_set_Void_IconInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x0600263E RID: 9790 RVA: 0x0008C304 File Offset: 0x0008A504
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709408, XrefRangeEnd = 709429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.SpawnedIcon.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600263F RID: 9791 RVA: 0x0008C340 File Offset: 0x0008A540
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709429, XrefRangeEnd = 709437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool PrintMembers(StringBuilder builder)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.SpawnedIcon.NativeMethodInfoPtr_PrintMembers_Private_Boolean_StringBuilder_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002640 RID: 9792 RVA: 0x0008C394 File Offset: 0x0008A594
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709437, XrefRangeEnd = 709441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool operator !=(WormVariableAgentDestinationRenderer.SpawnedIcon left, WormVariableAgentDestinationRenderer.SpawnedIcon right)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.SpawnedIcon.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SpawnedIcon_SpawnedIcon_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002641 RID: 9793 RVA: 0x0008C3F4 File Offset: 0x0008A5F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709441, XrefRangeEnd = 709442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool operator ==(WormVariableAgentDestinationRenderer.SpawnedIcon left, WormVariableAgentDestinationRenderer.SpawnedIcon right)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.SpawnedIcon.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SpawnedIcon_SpawnedIcon_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002642 RID: 9794 RVA: 0x0008C454 File Offset: 0x0008A654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709442, XrefRangeEnd = 709448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.SpawnedIcon.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002643 RID: 9795 RVA: 0x0008C498 File Offset: 0x0008A698
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709448, XrefRangeEnd = 709452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Equals(global::Il2CppSystem.Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.SpawnedIcon.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002644 RID: 9796 RVA: 0x0008C4EC File Offset: 0x0008A6EC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 709456, RefRangeEnd = 709458, XrefRangeStart = 709452, XrefRangeEnd = 709456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Equals(WormVariableAgentDestinationRenderer.SpawnedIcon other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.SpawnedIcon.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SpawnedIcon_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002645 RID: 9797 RVA: 0x0008C544 File Offset: 0x0008A744
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 577627, RefRangeEnd = 577628, XrefRangeStart = 577627, XrefRangeEnd = 577628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Deconstruct(out GameObject Obj, out WormVariableAgentDestinationRenderer.IconInfo Info)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = 0;
					ptr2 = &intPtr;
				}
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = 0;
				ptr3 = &intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.SpawnedIcon.NativeMethodInfoPtr_Deconstruct_Public_Void_byref_GameObject_byref_IconInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				IntPtr intPtr5 = intPtr;
				Obj = ((intPtr5 == 0) ? null : new GameObject(intPtr5));
				IntPtr intPtr6 = intPtr2;
				Info = ((intPtr6 == 0) ? null : new WormVariableAgentDestinationRenderer.IconInfo(intPtr6));
			}

			// Token: 0x06002646 RID: 9798 RVA: 0x0001522D File Offset: 0x0001342D
			public SpawnedIcon(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002647 RID: 9799 RVA: 0x00015236 File Offset: 0x00013436
			public SpawnedIcon()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.SpawnedIcon>.NativeClassPtr))
			{
			}

			// Token: 0x17000A9E RID: 2718
			// (get) Token: 0x06002648 RID: 9800 RVA: 0x0008C5C0 File Offset: 0x0008A7C0
			// (set) Token: 0x06002649 RID: 9801 RVA: 0x00015248 File Offset: 0x00013448
			public unsafe GameObject _Obj_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.SpawnedIcon.NativeFieldInfoPtr__Obj_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.SpawnedIcon.NativeFieldInfoPtr__Obj_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A9F RID: 2719
			// (get) Token: 0x0600264A RID: 9802 RVA: 0x0008C5F0 File Offset: 0x0008A7F0
			// (set) Token: 0x0600264B RID: 9803 RVA: 0x00015267 File Offset: 0x00013467
			public unsafe WormVariableAgentDestinationRenderer.IconInfo _Info_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.SpawnedIcon.NativeFieldInfoPtr__Info_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormVariableAgentDestinationRenderer.IconInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.SpawnedIcon.NativeFieldInfoPtr__Info_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001600 RID: 5632
			private static readonly IntPtr NativeFieldInfoPtr__Obj_k__BackingField;

			// Token: 0x04001601 RID: 5633
			private static readonly IntPtr NativeFieldInfoPtr__Info_k__BackingField;

			// Token: 0x04001602 RID: 5634
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameObject_IconInfo_0;

			// Token: 0x04001603 RID: 5635
			private static readonly IntPtr NativeMethodInfoPtr_get_Obj_Public_get_GameObject_0;

			// Token: 0x04001604 RID: 5636
			private static readonly IntPtr NativeMethodInfoPtr_set_Obj_Public_set_Void_GameObject_0;

			// Token: 0x04001605 RID: 5637
			private static readonly IntPtr NativeMethodInfoPtr_get_Info_Public_get_IconInfo_0;

			// Token: 0x04001606 RID: 5638
			private static readonly IntPtr NativeMethodInfoPtr_set_Info_Public_set_Void_IconInfo_0;

			// Token: 0x04001607 RID: 5639
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x04001608 RID: 5640
			private static readonly IntPtr NativeMethodInfoPtr_PrintMembers_Private_Boolean_StringBuilder_0;

			// Token: 0x04001609 RID: 5641
			private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SpawnedIcon_SpawnedIcon_0;

			// Token: 0x0400160A RID: 5642
			private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SpawnedIcon_SpawnedIcon_0;

			// Token: 0x0400160B RID: 5643
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x0400160C RID: 5644
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

			// Token: 0x0400160D RID: 5645
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SpawnedIcon_0;

			// Token: 0x0400160E RID: 5646
			private static readonly IntPtr NativeMethodInfoPtr_Deconstruct_Public_Void_byref_GameObject_byref_IconInfo_0;
		}

		// Token: 0x020003B5 RID: 949
		[Serializable]
		public sealed class ObjectIconPair : ValueType
		{
			// Token: 0x0600264C RID: 9804 RVA: 0x0008C620 File Offset: 0x0008A820
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectIconPair()
			{
				Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.ObjectIconPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer>.NativeClassPtr, "ObjectIconPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.ObjectIconPair>.NativeClassPtr);
				WormVariableAgentDestinationRenderer.ObjectIconPair.NativeFieldInfoPtr_icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.ObjectIconPair>.NativeClassPtr, "icon");
				WormVariableAgentDestinationRenderer.ObjectIconPair.NativeFieldInfoPtr_obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.ObjectIconPair>.NativeClassPtr, "obj");
				WormVariableAgentDestinationRenderer.ObjectIconPair.NativeFieldInfoPtr_infiltrateObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.ObjectIconPair>.NativeClassPtr, "infiltrateObj");
				WormVariableAgentDestinationRenderer.ObjectIconPair.NativeFieldInfoPtr_conditionalObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.ObjectIconPair>.NativeClassPtr, "conditionalObj");
				WormVariableAgentDestinationRenderer.ObjectIconPair.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObjectIconPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.ObjectIconPair>.NativeClassPtr, 100665589);
				WormVariableAgentDestinationRenderer.ObjectIconPair.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.ObjectIconPair>.NativeClassPtr, 100665590);
				WormVariableAgentDestinationRenderer.ObjectIconPair.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.ObjectIconPair>.NativeClassPtr, 100665591);
				WormVariableAgentDestinationRenderer.ObjectIconPair.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ObjectIconPair_ObjectIconPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.ObjectIconPair>.NativeClassPtr, 100665592);
				WormVariableAgentDestinationRenderer.ObjectIconPair.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ObjectIconPair_ObjectIconPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.ObjectIconPair>.NativeClassPtr, 100665593);
			}

			// Token: 0x0600264D RID: 9805 RVA: 0x0008C700 File Offset: 0x0008A900
			[CallerCount(0)]
			public unsafe bool Equals(WormVariableAgentDestinationRenderer.ObjectIconPair other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.ObjectIconPair.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObjectIconPair_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600264E RID: 9806 RVA: 0x0008C758 File Offset: 0x0008A958
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709458, XrefRangeEnd = 709461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Equals(global::Il2CppSystem.Object other)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.ObjectIconPair.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600264F RID: 9807 RVA: 0x0008C7AC File Offset: 0x0008A9AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709461, XrefRangeEnd = 709462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.ObjectIconPair.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002650 RID: 9808 RVA: 0x0008C7F0 File Offset: 0x0008A9F0
			[CallerCount(0)]
			public unsafe static bool operator ==(WormVariableAgentDestinationRenderer.ObjectIconPair left, WormVariableAgentDestinationRenderer.ObjectIconPair right)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.ObjectIconPair.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ObjectIconPair_ObjectIconPair_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002651 RID: 9809 RVA: 0x0008C850 File Offset: 0x0008AA50
			[CallerCount(0)]
			public unsafe static bool operator !=(WormVariableAgentDestinationRenderer.ObjectIconPair left, WormVariableAgentDestinationRenderer.ObjectIconPair right)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer.ObjectIconPair.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ObjectIconPair_ObjectIconPair_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002652 RID: 9810 RVA: 0x00015286 File Offset: 0x00013486
			public ObjectIconPair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002653 RID: 9811 RVA: 0x0001528F File Offset: 0x0001348F
			public ObjectIconPair()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer.ObjectIconPair>.NativeClassPtr))
			{
			}

			// Token: 0x17000AA2 RID: 2722
			// (get) Token: 0x06002654 RID: 9812 RVA: 0x0008C8B0 File Offset: 0x0008AAB0
			// (set) Token: 0x06002655 RID: 9813 RVA: 0x000152A1 File Offset: 0x000134A1
			public unsafe AgentIcons icon
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.ObjectIconPair.NativeFieldInfoPtr_icon);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.ObjectIconPair.NativeFieldInfoPtr_icon)) = value;
				}
			}

			// Token: 0x17000AA3 RID: 2723
			// (get) Token: 0x06002656 RID: 9814 RVA: 0x0008C8D8 File Offset: 0x0008AAD8
			// (set) Token: 0x06002657 RID: 9815 RVA: 0x000152BC File Offset: 0x000134BC
			public unsafe GameObject obj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.ObjectIconPair.NativeFieldInfoPtr_obj);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.ObjectIconPair.NativeFieldInfoPtr_obj), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AA4 RID: 2724
			// (get) Token: 0x06002658 RID: 9816 RVA: 0x0008C908 File Offset: 0x0008AB08
			// (set) Token: 0x06002659 RID: 9817 RVA: 0x000152DB File Offset: 0x000134DB
			public unsafe GameObject infiltrateObj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.ObjectIconPair.NativeFieldInfoPtr_infiltrateObj);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.ObjectIconPair.NativeFieldInfoPtr_infiltrateObj), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AA5 RID: 2725
			// (get) Token: 0x0600265A RID: 9818 RVA: 0x0008C938 File Offset: 0x0008AB38
			// (set) Token: 0x0600265B RID: 9819 RVA: 0x000152FA File Offset: 0x000134FA
			public unsafe Animator conditionalObj
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.ObjectIconPair.NativeFieldInfoPtr_conditionalObj);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer.ObjectIconPair.NativeFieldInfoPtr_conditionalObj), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400160F RID: 5647
			private static readonly IntPtr NativeFieldInfoPtr_icon;

			// Token: 0x04001610 RID: 5648
			private static readonly IntPtr NativeFieldInfoPtr_obj;

			// Token: 0x04001611 RID: 5649
			private static readonly IntPtr NativeFieldInfoPtr_infiltrateObj;

			// Token: 0x04001612 RID: 5650
			private static readonly IntPtr NativeFieldInfoPtr_conditionalObj;

			// Token: 0x04001613 RID: 5651
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ObjectIconPair_0;

			// Token: 0x04001614 RID: 5652
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

			// Token: 0x04001615 RID: 5653
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x04001616 RID: 5654
			private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ObjectIconPair_ObjectIconPair_0;

			// Token: 0x04001617 RID: 5655
			private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ObjectIconPair_ObjectIconPair_0;
		}

		// Token: 0x020003B6 RID: 950
		[ObfuscatedName("worm.match.dataRenderers.WormVariableAgentDestinationRenderer+<Init>d__21")]
		public sealed class _Init_d__21 : global::Il2CppSystem.Object
		{
			// Token: 0x0600265C RID: 9820 RVA: 0x0008C968 File Offset: 0x0008AB68
			// Note: this type is marked as 'beforefieldinit'.
			static _Init_d__21()
			{
				Il2CppClassPointerStore<WormVariableAgentDestinationRenderer._Init_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer>.NativeClassPtr, "<Init>d__21");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer._Init_d__21>.NativeClassPtr);
				WormVariableAgentDestinationRenderer._Init_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer._Init_d__21>.NativeClassPtr, "<>1__state");
				WormVariableAgentDestinationRenderer._Init_d__21.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer._Init_d__21>.NativeClassPtr, "<>2__current");
				WormVariableAgentDestinationRenderer._Init_d__21.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer._Init_d__21>.NativeClassPtr, "<>4__this");
				WormVariableAgentDestinationRenderer._Init_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer._Init_d__21>.NativeClassPtr, 100665594);
				WormVariableAgentDestinationRenderer._Init_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer._Init_d__21>.NativeClassPtr, 100665595);
				WormVariableAgentDestinationRenderer._Init_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer._Init_d__21>.NativeClassPtr, 100665596);
				WormVariableAgentDestinationRenderer._Init_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer._Init_d__21>.NativeClassPtr, 100665597);
				WormVariableAgentDestinationRenderer._Init_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer._Init_d__21>.NativeClassPtr, 100665598);
				WormVariableAgentDestinationRenderer._Init_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer._Init_d__21>.NativeClassPtr, 100665599);
			}

			// Token: 0x0600265D RID: 9821 RVA: 0x0008CA48 File Offset: 0x0008AC48
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Init_d__21(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormVariableAgentDestinationRenderer._Init_d__21>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer._Init_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600265E RID: 9822 RVA: 0x0008CA90 File Offset: 0x0008AC90
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer._Init_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600265F RID: 9823 RVA: 0x0008CAC4 File Offset: 0x0008ACC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709462, XrefRangeEnd = 709465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer._Init_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000AA9 RID: 2729
			// (get) Token: 0x06002660 RID: 9824 RVA: 0x0008CB00 File Offset: 0x0008AD00
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer._Init_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002661 RID: 9825 RVA: 0x0008CB40 File Offset: 0x0008AD40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 709465, XrefRangeEnd = 709470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer._Init_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000AAA RID: 2730
			// (get) Token: 0x06002662 RID: 9826 RVA: 0x0008CB74 File Offset: 0x0008AD74
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormVariableAgentDestinationRenderer._Init_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002663 RID: 9827 RVA: 0x00015319 File Offset: 0x00013519
			public _Init_d__21(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AA6 RID: 2726
			// (get) Token: 0x06002664 RID: 9828 RVA: 0x0008CBB4 File Offset: 0x0008ADB4
			// (set) Token: 0x06002665 RID: 9829 RVA: 0x00015322 File Offset: 0x00013522
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer._Init_d__21.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer._Init_d__21.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000AA7 RID: 2727
			// (get) Token: 0x06002666 RID: 9830 RVA: 0x0008CBDC File Offset: 0x0008ADDC
			// (set) Token: 0x06002667 RID: 9831 RVA: 0x0001533D File Offset: 0x0001353D
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer._Init_d__21.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer._Init_d__21.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AA8 RID: 2728
			// (get) Token: 0x06002668 RID: 9832 RVA: 0x0008CC0C File Offset: 0x0008AE0C
			// (set) Token: 0x06002669 RID: 9833 RVA: 0x0001535C File Offset: 0x0001355C
			public unsafe WormVariableAgentDestinationRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer._Init_d__21.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormVariableAgentDestinationRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormVariableAgentDestinationRenderer._Init_d__21.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001618 RID: 5656
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001619 RID: 5657
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400161A RID: 5658
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400161B RID: 5659
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400161C RID: 5660
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400161D RID: 5661
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400161E RID: 5662
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400161F RID: 5663
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001620 RID: 5664
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
