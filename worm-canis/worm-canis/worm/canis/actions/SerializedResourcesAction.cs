using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.actions
{
	// Token: 0x02000245 RID: 581
	public class SerializedResourcesAction : SerializedAction
	{
		// Token: 0x0600194B RID: 6475 RVA: 0x000BB4F0 File Offset: 0x000B96F0
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedResourcesAction()
		{
			Il2CppClassPointerStore<SerializedResourcesAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedResourcesAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedResourcesAction>.NativeClassPtr);
			SerializedResourcesAction.NativeFieldInfoPtr_AttributeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedResourcesAction>.NativeClassPtr, "AttributeKey");
			SerializedResourcesAction.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedResourcesAction>.NativeClassPtr, "Amount");
			SerializedResourcesAction.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedResourcesAction>.NativeClassPtr, 100667859);
			SerializedResourcesAction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedResourcesAction>.NativeClassPtr, 100667860);
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x000BB570 File Offset: 0x000B9770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136124, XrefRangeEnd = 136159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedResourcesAction.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x000BB5CC File Offset: 0x000B97CC
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedResourcesAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedResourcesAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedResourcesAction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x0000AE0C File Offset: 0x0000900C
		public SerializedResourcesAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x0600194F RID: 6479 RVA: 0x000BB608 File Offset: 0x000B9808
		// (set) Token: 0x06001950 RID: 6480 RVA: 0x0000AE15 File Offset: 0x00009015
		public unsafe int AttributeKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedResourcesAction.NativeFieldInfoPtr_AttributeKey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedResourcesAction.NativeFieldInfoPtr_AttributeKey)) = value;
			}
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06001951 RID: 6481 RVA: 0x000BB630 File Offset: 0x000B9830
		// (set) Token: 0x06001952 RID: 6482 RVA: 0x0000AE30 File Offset: 0x00009030
		public unsafe int Amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedResourcesAction.NativeFieldInfoPtr_Amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedResourcesAction.NativeFieldInfoPtr_Amount)) = value;
			}
		}

		// Token: 0x04000FA2 RID: 4002
		private static readonly IntPtr NativeFieldInfoPtr_AttributeKey;

		// Token: 0x04000FA3 RID: 4003
		private static readonly IntPtr NativeFieldInfoPtr_Amount;

		// Token: 0x04000FA4 RID: 4004
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000FA5 RID: 4005
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
