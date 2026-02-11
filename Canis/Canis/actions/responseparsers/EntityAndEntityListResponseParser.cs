using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.selection.messages.outgoing;

namespace Canis.actions.responseparsers
{
	// Token: 0x02000213 RID: 531
	[Serializable]
	public class EntityAndEntityListResponseParser : ResponseParser<EntityIDTargetResponses>
	{
		// Token: 0x0600165B RID: 5723 RVA: 0x00073254 File Offset: 0x00071454
		// Note: this type is marked as 'beforefieldinit'.
		static EntityAndEntityListResponseParser()
		{
			Il2CppClassPointerStore<EntityAndEntityListResponseParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.responseparsers", "EntityAndEntityListResponseParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityAndEntityListResponseParser>.NativeClassPtr);
			EntityAndEntityListResponseParser.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityAndEntityListResponseParser>.NativeClassPtr, "Instance");
			EntityAndEntityListResponseParser.NativeMethodInfoPtr_ParseResponse_Public_Virtual_IEnumerable_1_EntityIDTargetResponses_Match_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityAndEntityListResponseParser>.NativeClassPtr, 100668387);
			EntityAndEntityListResponseParser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityAndEntityListResponseParser>.NativeClassPtr, 100668388);
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x000732C0 File Offset: 0x000714C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593391, XrefRangeEnd = 593403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<EntityIDTargetResponses> ParseResponse(Match match, Object responseMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(responseMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityAndEntityListResponseParser.NativeMethodInfoPtr_ParseResponse_Public_Virtual_IEnumerable_1_EntityIDTargetResponses_Match_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<EntityIDTargetResponses>>(intPtr3) : null;
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x00073330 File Offset: 0x00071530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593403, XrefRangeEnd = 593406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityAndEntityListResponseParser()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityAndEntityListResponseParser>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityAndEntityListResponseParser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x0000AC15 File Offset: 0x00008E15
		public EntityAndEntityListResponseParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x0600165F RID: 5727 RVA: 0x0007336C File Offset: 0x0007156C
		// (set) Token: 0x06001660 RID: 5728 RVA: 0x0000AC1E File Offset: 0x00008E1E
		public unsafe static EntityAndEntityListResponseParser Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EntityAndEntityListResponseParser.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityAndEntityListResponseParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EntityAndEntityListResponseParser.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E63 RID: 3683
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x04000E64 RID: 3684
		private static readonly IntPtr NativeMethodInfoPtr_ParseResponse_Public_Virtual_IEnumerable_1_EntityIDTargetResponses_Match_Object_0;

		// Token: 0x04000E65 RID: 3685
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
