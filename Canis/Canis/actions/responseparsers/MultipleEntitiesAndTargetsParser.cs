using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.selection.messages.outgoing;

namespace Canis.actions.responseparsers
{
	// Token: 0x02000217 RID: 535
	[Serializable]
	public class MultipleEntitiesAndTargetsParser : ResponseParser<List<EntityIDEntityTargetsResponse>>
	{
		// Token: 0x06001673 RID: 5747 RVA: 0x0007376C File Offset: 0x0007196C
		// Note: this type is marked as 'beforefieldinit'.
		static MultipleEntitiesAndTargetsParser()
		{
			Il2CppClassPointerStore<MultipleEntitiesAndTargetsParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.responseparsers", "MultipleEntitiesAndTargetsParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultipleEntitiesAndTargetsParser>.NativeClassPtr);
			MultipleEntitiesAndTargetsParser.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultipleEntitiesAndTargetsParser>.NativeClassPtr, "Instance");
			MultipleEntitiesAndTargetsParser.NativeMethodInfoPtr_ParseResponse_Public_Virtual_IEnumerable_1_List_1_EntityIDEntityTargetsResponse_Match_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleEntitiesAndTargetsParser>.NativeClassPtr, 100668409);
			MultipleEntitiesAndTargetsParser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultipleEntitiesAndTargetsParser>.NativeClassPtr, 100668410);
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x000737D8 File Offset: 0x000719D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593522, XrefRangeEnd = 593534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<List<EntityIDEntityTargetsResponse>> ParseResponse(Match match, Object responseMessage)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MultipleEntitiesAndTargetsParser.NativeMethodInfoPtr_ParseResponse_Public_Virtual_IEnumerable_1_List_1_EntityIDEntityTargetsResponse_Match_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<List<EntityIDEntityTargetsResponse>>>(intPtr3) : null;
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x00073848 File Offset: 0x00071A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593534, XrefRangeEnd = 593537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultipleEntitiesAndTargetsParser()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultipleEntitiesAndTargetsParser>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultipleEntitiesAndTargetsParser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x0000AC8E File Offset: 0x00008E8E
		public MultipleEntitiesAndTargetsParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06001677 RID: 5751 RVA: 0x00073884 File Offset: 0x00071A84
		// (set) Token: 0x06001678 RID: 5752 RVA: 0x0000AC97 File Offset: 0x00008E97
		public unsafe static MultipleEntitiesAndTargetsParser Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultipleEntitiesAndTargetsParser.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultipleEntitiesAndTargetsParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultipleEntitiesAndTargetsParser.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E6F RID: 3695
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x04000E70 RID: 3696
		private static readonly IntPtr NativeMethodInfoPtr_ParseResponse_Public_Virtual_IEnumerable_1_List_1_EntityIDEntityTargetsResponse_Match_Object_0;

		// Token: 0x04000E71 RID: 3697
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
