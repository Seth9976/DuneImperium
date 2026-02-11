using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.ObjectModel;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000069 RID: 105
	public sealed class MemberInitExpression : Expression
	{
		// Token: 0x060005B9 RID: 1465 RVA: 0x0002BCEC File Offset: 0x00029EEC
		// Note: this type is marked as 'beforefieldinit'.
		static MemberInitExpression()
		{
			Il2CppClassPointerStore<MemberInitExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "MemberInitExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemberInitExpression>.NativeClassPtr);
			MemberInitExpression.NativeFieldInfoPtr__NewExpression_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberInitExpression>.NativeClassPtr, "<NewExpression>k__BackingField");
			MemberInitExpression.NativeFieldInfoPtr__Bindings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberInitExpression>.NativeClassPtr, "<Bindings>k__BackingField");
			MemberInitExpression.NativeMethodInfoPtr_get_NewExpression_Public_get_NewExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInitExpression>.NativeClassPtr, 100664523);
			MemberInitExpression.NativeMethodInfoPtr_get_Bindings_Public_get_ReadOnlyCollection_1_MemberBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberInitExpression>.NativeClassPtr, 100664524);
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060005BA RID: 1466 RVA: 0x0002BD6C File Offset: 0x00029F6C
		public unsafe NewExpression NewExpression
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberInitExpression.NativeMethodInfoPtr_get_NewExpression_Public_get_NewExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NewExpression>(intPtr3) : null;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x0002BDAC File Offset: 0x00029FAC
		public unsafe ReadOnlyCollection<MemberBinding> Bindings
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberInitExpression.NativeMethodInfoPtr_get_Bindings_Public_get_ReadOnlyCollection_1_MemberBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<MemberBinding>>(intPtr3) : null;
			}
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x000035B6 File Offset: 0x000017B6
		public MemberInitExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x0002BDEC File Offset: 0x00029FEC
		// (set) Token: 0x060005BE RID: 1470 RVA: 0x000035BF File Offset: 0x000017BF
		public unsafe NewExpression _NewExpression_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInitExpression.NativeFieldInfoPtr__NewExpression_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NewExpression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInitExpression.NativeFieldInfoPtr__NewExpression_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x0002BE1C File Offset: 0x0002A01C
		// (set) Token: 0x060005C0 RID: 1472 RVA: 0x000035DE File Offset: 0x000017DE
		public unsafe ReadOnlyCollection<MemberBinding> _Bindings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInitExpression.NativeFieldInfoPtr__Bindings_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<MemberBinding>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberInitExpression.NativeFieldInfoPtr__Bindings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004B3 RID: 1203
		private static readonly IntPtr NativeFieldInfoPtr__NewExpression_k__BackingField;

		// Token: 0x040004B4 RID: 1204
		private static readonly IntPtr NativeFieldInfoPtr__Bindings_k__BackingField;

		// Token: 0x040004B5 RID: 1205
		private static readonly IntPtr NativeMethodInfoPtr_get_NewExpression_Public_get_NewExpression_0;

		// Token: 0x040004B6 RID: 1206
		private static readonly IntPtr NativeMethodInfoPtr_get_Bindings_Public_get_ReadOnlyCollection_1_MemberBinding_0;
	}
}
