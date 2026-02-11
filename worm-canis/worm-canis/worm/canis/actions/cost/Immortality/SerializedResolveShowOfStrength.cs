using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions.cost.Immortality
{
	// Token: 0x02000319 RID: 793
	public class SerializedResolveShowOfStrength : SerializedAction
	{
		// Token: 0x06002050 RID: 8272 RVA: 0x000D7720 File Offset: 0x000D5920
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedResolveShowOfStrength()
		{
			Il2CppClassPointerStore<SerializedResolveShowOfStrength>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.cost.Immortality", "SerializedResolveShowOfStrength");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedResolveShowOfStrength>.NativeClassPtr);
			SerializedResolveShowOfStrength.NativeFieldInfoPtr_IntResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedResolveShowOfStrength>.NativeClassPtr, "IntResponse");
			SerializedResolveShowOfStrength.NativeFieldInfoPtr_ArchID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedResolveShowOfStrength>.NativeClassPtr, "ArchID");
			SerializedResolveShowOfStrength.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedResolveShowOfStrength>.NativeClassPtr, 100671206);
			SerializedResolveShowOfStrength.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedResolveShowOfStrength>.NativeClassPtr, 100671207);
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x000D77A0 File Offset: 0x000D59A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedResolveShowOfStrength.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x000D77FC File Offset: 0x000D59FC
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedResolveShowOfStrength()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedResolveShowOfStrength>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedResolveShowOfStrength.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x0000D5E3 File Offset: 0x0000B7E3
		public SerializedResolveShowOfStrength(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06002054 RID: 8276 RVA: 0x000D7838 File Offset: 0x000D5A38
		// (set) Token: 0x06002055 RID: 8277 RVA: 0x0000D5EC File Offset: 0x0000B7EC
		public unsafe int IntResponse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedResolveShowOfStrength.NativeFieldInfoPtr_IntResponse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedResolveShowOfStrength.NativeFieldInfoPtr_IntResponse)) = value;
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06002056 RID: 8278 RVA: 0x000D7860 File Offset: 0x000D5A60
		// (set) Token: 0x06002057 RID: 8279 RVA: 0x0000D607 File Offset: 0x0000B807
		public unsafe ArchetypeID ArchID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedResolveShowOfStrength.NativeFieldInfoPtr_ArchID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedResolveShowOfStrength.NativeFieldInfoPtr_ArchID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400145E RID: 5214
		private static readonly IntPtr NativeFieldInfoPtr_IntResponse;

		// Token: 0x0400145F RID: 5215
		private static readonly IntPtr NativeFieldInfoPtr_ArchID;

		// Token: 0x04001460 RID: 5216
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04001461 RID: 5217
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
