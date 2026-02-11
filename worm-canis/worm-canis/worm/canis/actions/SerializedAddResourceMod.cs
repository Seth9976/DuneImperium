using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using worm.canis.data.attributes.resource;

namespace worm.canis.actions
{
	// Token: 0x02000225 RID: 549
	public class SerializedAddResourceMod : SerializedAction
	{
		// Token: 0x0600183A RID: 6202 RVA: 0x000B70AC File Offset: 0x000B52AC
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedAddResourceMod()
		{
			Il2CppClassPointerStore<SerializedAddResourceMod>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedAddResourceMod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedAddResourceMod>.NativeClassPtr);
			SerializedAddResourceMod.NativeFieldInfoPtr_ResourceMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedAddResourceMod>.NativeClassPtr, "ResourceMod");
			SerializedAddResourceMod.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedAddResourceMod>.NativeClassPtr, 100667434);
			SerializedAddResourceMod.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedAddResourceMod>.NativeClassPtr, 100667435);
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x000B7118 File Offset: 0x000B5318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131733, XrefRangeEnd = 131741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedAddResourceMod.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x000B7174 File Offset: 0x000B5374
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedAddResourceMod()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedAddResourceMod>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedAddResourceMod.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x0000A846 File Offset: 0x00008A46
		public SerializedAddResourceMod(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x0600183E RID: 6206 RVA: 0x000B71B0 File Offset: 0x000B53B0
		// (set) Token: 0x0600183F RID: 6207 RVA: 0x0000A84F File Offset: 0x00008A4F
		public unsafe ResourceMod ResourceMod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAddResourceMod.NativeFieldInfoPtr_ResourceMod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceMod>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAddResourceMod.NativeFieldInfoPtr_ResourceMod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EFA RID: 3834
		private static readonly IntPtr NativeFieldInfoPtr_ResourceMod;

		// Token: 0x04000EFB RID: 3835
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000EFC RID: 3836
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
