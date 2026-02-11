using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions.Immortality
{
	// Token: 0x020002DC RID: 732
	public class SerializedConvertSpecimen : SerializedAction
	{
		// Token: 0x06001E1B RID: 7707 RVA: 0x000CE7DC File Offset: 0x000CC9DC
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedConvertSpecimen()
		{
			Il2CppClassPointerStore<SerializedConvertSpecimen>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.Immortality", "SerializedConvertSpecimen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedConvertSpecimen>.NativeClassPtr);
			SerializedConvertSpecimen.NativeFieldInfoPtr_PlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedConvertSpecimen>.NativeClassPtr, "PlayerID");
			SerializedConvertSpecimen.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedConvertSpecimen>.NativeClassPtr, 100670321);
			SerializedConvertSpecimen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedConvertSpecimen>.NativeClassPtr, 100670322);
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x000CE848 File Offset: 0x000CCA48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169960, XrefRangeEnd = 169968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedConvertSpecimen.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x000CE8A4 File Offset: 0x000CCAA4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedConvertSpecimen()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedConvertSpecimen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedConvertSpecimen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x0000C9A7 File Offset: 0x0000ABA7
		public SerializedConvertSpecimen(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06001E1F RID: 7711 RVA: 0x000CE8E0 File Offset: 0x000CCAE0
		// (set) Token: 0x06001E20 RID: 7712 RVA: 0x0000C9B0 File Offset: 0x0000ABB0
		public unsafe EntityID PlayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedConvertSpecimen.NativeFieldInfoPtr_PlayerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedConvertSpecimen.NativeFieldInfoPtr_PlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012FC RID: 4860
		private static readonly IntPtr NativeFieldInfoPtr_PlayerID;

		// Token: 0x040012FD RID: 4861
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x040012FE RID: 4862
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
