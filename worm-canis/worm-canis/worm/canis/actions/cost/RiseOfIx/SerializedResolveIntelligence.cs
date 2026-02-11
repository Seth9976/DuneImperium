using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.canis.actions.cost.RiseOfIx
{
	// Token: 0x0200030F RID: 783
	public class SerializedResolveIntelligence : SerializedAction
	{
		// Token: 0x06002001 RID: 8193 RVA: 0x000D6274 File Offset: 0x000D4474
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedResolveIntelligence()
		{
			Il2CppClassPointerStore<SerializedResolveIntelligence>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.cost.RiseOfIx", "SerializedResolveIntelligence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedResolveIntelligence>.NativeClassPtr);
			SerializedResolveIntelligence.NativeFieldInfoPtr_Targets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedResolveIntelligence>.NativeClassPtr, "Targets");
			SerializedResolveIntelligence.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedResolveIntelligence>.NativeClassPtr, 100671077);
			SerializedResolveIntelligence.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedResolveIntelligence>.NativeClassPtr, 100671078);
		}

		// Token: 0x06002002 RID: 8194 RVA: 0x000D62E0 File Offset: 0x000D44E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174719, XrefRangeEnd = 174749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedResolveIntelligence.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06002003 RID: 8195 RVA: 0x000D633C File Offset: 0x000D453C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedResolveIntelligence()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedResolveIntelligence>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedResolveIntelligence.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002004 RID: 8196 RVA: 0x0000D486 File Offset: 0x0000B686
		public SerializedResolveIntelligence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06002005 RID: 8197 RVA: 0x000D6378 File Offset: 0x000D4578
		// (set) Token: 0x06002006 RID: 8198 RVA: 0x0000D48F File Offset: 0x0000B68F
		public unsafe List<EntityID> Targets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedResolveIntelligence.NativeFieldInfoPtr_Targets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedResolveIntelligence.NativeFieldInfoPtr_Targets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400142C RID: 5164
		private static readonly IntPtr NativeFieldInfoPtr_Targets;

		// Token: 0x0400142D RID: 5165
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x0400142E RID: 5166
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
