using System;
using System.Runtime.InteropServices;
using Canis.context;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.actions
{
	// Token: 0x02000172 RID: 370
	public class CostAction : Action
	{
		// Token: 0x0600108D RID: 4237 RVA: 0x0005CD08 File Offset: 0x0005AF08
		// Note: this type is marked as 'beforefieldinit'.
		static CostAction()
		{
			Il2CppClassPointerStore<CostAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "CostAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CostAction>.NativeClassPtr);
			CostAction.NativeMethodInfoPtr__ctor_Public_Void_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CostAction>.NativeClassPtr, 100666700);
			CostAction.NativeMethodInfoPtr_CanBePaid_Public_Abstract_Virtual_New_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CostAction>.NativeClassPtr, 100666701);
			CostAction.NativeMethodInfoPtr_Then_Public_Virtual_New_CostAction_CostAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CostAction>.NativeClassPtr, 100666702);
			CostAction.NativeMethodInfoPtr_Then_Public_Virtual_New_CostAction_Il2CppReferenceArray_1_CostAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CostAction>.NativeClassPtr, 100666703);
			CostAction.NativeMethodInfoPtr_Or_Public_CostAction_CostAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CostAction>.NativeClassPtr, 100666704);
			CostAction.NativeMethodInfoPtr_op_LogicalNot_Public_Static_InverseCostAction_CostAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CostAction>.NativeClassPtr, 100666705);
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x0005CDB0 File Offset: 0x0005AFB0
		[CallerCount(605)]
		[CachedScanResults(RefRangeStart = 579585, RefRangeEnd = 580190, XrefRangeStart = 579585, XrefRangeEnd = 580190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CostAction(Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CostAction>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CostAction.NativeMethodInfoPtr__ctor_Public_Void_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x0005CDFC File Offset: 0x0005AFFC
		[CallerCount(0)]
		public unsafe virtual bool CanBePaid(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CostAction.NativeMethodInfoPtr_CanBePaid_Public_Abstract_Virtual_New_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x0005CE54 File Offset: 0x0005B054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 582253, XrefRangeEnd = 582264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual CostAction Then(CostAction next)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(next);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CostAction.NativeMethodInfoPtr_Then_Public_Virtual_New_CostAction_CostAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x0005CEB0 File Offset: 0x0005B0B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 582264, XrefRangeEnd = 582277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual CostAction Then([Optional] Il2CppReferenceArray<CostAction> next)
		{
			if (next == null)
			{
				next = new Il2CppReferenceArray<CostAction>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(next);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CostAction.NativeMethodInfoPtr_Then_Public_Virtual_New_CostAction_Il2CppReferenceArray_1_CostAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x0005CF18 File Offset: 0x0005B118
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 582288, RefRangeEnd = 582313, XrefRangeStart = 582277, XrefRangeEnd = 582288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CostAction Or(CostAction alternative)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(alternative);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CostAction.NativeMethodInfoPtr_Or_Public_CostAction_CostAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x0005CF68 File Offset: 0x0005B168
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 582319, RefRangeEnd = 582321, XrefRangeStart = 582313, XrefRangeEnd = 582319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InverseCostAction operator !(CostAction cost)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cost);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CostAction.NativeMethodInfoPtr_op_LogicalNot_Public_Static_InverseCostAction_CostAction_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InverseCostAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x00008524 File Offset: 0x00006724
		public virtual CostAction Then(params CostAction[] next)
		{
			return this.Then(new Il2CppReferenceArray<CostAction>(next));
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x00008532 File Offset: 0x00006732
		public CostAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AF0 RID: 2800
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_0;

		// Token: 0x04000AF1 RID: 2801
		private static readonly IntPtr NativeMethodInfoPtr_CanBePaid_Public_Abstract_Virtual_New_Boolean_Context_0;

		// Token: 0x04000AF2 RID: 2802
		private static readonly IntPtr NativeMethodInfoPtr_Then_Public_Virtual_New_CostAction_CostAction_0;

		// Token: 0x04000AF3 RID: 2803
		private static readonly IntPtr NativeMethodInfoPtr_Then_Public_Virtual_New_CostAction_Il2CppReferenceArray_1_CostAction_0;

		// Token: 0x04000AF4 RID: 2804
		private static readonly IntPtr NativeMethodInfoPtr_Or_Public_CostAction_CostAction_0;

		// Token: 0x04000AF5 RID: 2805
		private static readonly IntPtr NativeMethodInfoPtr_op_LogicalNot_Public_Static_InverseCostAction_CostAction_0;
	}
}
