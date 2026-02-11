using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x0200007D RID: 125
	public class NewExpression : Expression
	{
		// Token: 0x06000669 RID: 1641 RVA: 0x0002E730 File Offset: 0x0002C930
		// Note: this type is marked as 'beforefieldinit'.
		static NewExpression()
		{
			Il2CppClassPointerStore<NewExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "NewExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewExpression>.NativeClassPtr);
			NewExpression.NativeFieldInfoPtr__arguments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewExpression>.NativeClassPtr, "_arguments");
			NewExpression.NativeFieldInfoPtr__Constructor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewExpression>.NativeClassPtr, "<Constructor>k__BackingField");
			NewExpression.NativeMethodInfoPtr_get_Constructor_Public_get_ConstructorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewExpression>.NativeClassPtr, 100664597);
			NewExpression.NativeMethodInfoPtr_GetArgument_Public_Virtual_Final_New_Expression_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewExpression>.NativeClassPtr, 100664598);
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x0002E7B0 File Offset: 0x0002C9B0
		public unsafe ConstructorInfo Constructor
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewExpression.NativeMethodInfoPtr_get_Constructor_Public_get_ConstructorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x0002E7F0 File Offset: 0x0002C9F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1014576, RefRangeEnd = 1014577, XrefRangeStart = 1014572, XrefRangeEnd = 1014576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Expression GetArgument(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewExpression.NativeMethodInfoPtr_GetArgument_Public_Virtual_Final_New_Expression_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
			}
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00003A2B File Offset: 0x00001C2B
		public NewExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x0002E83C File Offset: 0x0002CA3C
		// (set) Token: 0x0600066E RID: 1646 RVA: 0x00003A34 File Offset: 0x00001C34
		public unsafe IReadOnlyList<Expression> _arguments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewExpression.NativeFieldInfoPtr__arguments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<Expression>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewExpression.NativeFieldInfoPtr__arguments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x0002E86C File Offset: 0x0002CA6C
		// (set) Token: 0x06000670 RID: 1648 RVA: 0x00003A53 File Offset: 0x00001C53
		public unsafe ConstructorInfo _Constructor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewExpression.NativeFieldInfoPtr__Constructor_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewExpression.NativeFieldInfoPtr__Constructor_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400051C RID: 1308
		private static readonly IntPtr NativeFieldInfoPtr__arguments;

		// Token: 0x0400051D RID: 1309
		private static readonly IntPtr NativeFieldInfoPtr__Constructor_k__BackingField;

		// Token: 0x0400051E RID: 1310
		private static readonly IntPtr NativeMethodInfoPtr_get_Constructor_Public_get_ConstructorInfo_0;

		// Token: 0x0400051F RID: 1311
		private static readonly IntPtr NativeMethodInfoPtr_GetArgument_Public_Virtual_Final_New_Expression_Int32_0;
	}
}
