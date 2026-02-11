using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000D4 RID: 212
	public sealed class IndexMethodByRefUpdater : ByRefUpdater
	{
		// Token: 0x06000D06 RID: 3334 RVA: 0x00045A7C File Offset: 0x00043C7C
		// Note: this type is marked as 'beforefieldinit'.
		static IndexMethodByRefUpdater()
		{
			Il2CppClassPointerStore<IndexMethodByRefUpdater>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "IndexMethodByRefUpdater");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IndexMethodByRefUpdater>.NativeClassPtr);
			IndexMethodByRefUpdater.NativeFieldInfoPtr__indexer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexMethodByRefUpdater>.NativeClassPtr, "_indexer");
			IndexMethodByRefUpdater.NativeFieldInfoPtr__obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexMethodByRefUpdater>.NativeClassPtr, "_obj");
			IndexMethodByRefUpdater.NativeFieldInfoPtr__args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexMethodByRefUpdater>.NativeClassPtr, "_args");
			IndexMethodByRefUpdater.NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_LocalDefinition_Il2CppReferenceArray_1_LocalDefinition_MethodInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexMethodByRefUpdater>.NativeClassPtr, 100665657);
			IndexMethodByRefUpdater.NativeMethodInfoPtr_Update_Public_Virtual_Void_InterpretedFrame_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexMethodByRefUpdater>.NativeClassPtr, 100665658);
			IndexMethodByRefUpdater.NativeMethodInfoPtr_UndefineTemps_Public_Virtual_Void_InstructionList_LocalVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexMethodByRefUpdater>.NativeClassPtr, 100665659);
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x00045B24 File Offset: 0x00043D24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1022422, RefRangeEnd = 1022423, XrefRangeStart = 1022418, XrefRangeEnd = 1022422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IndexMethodByRefUpdater(Nullable<LocalDefinition> obj, Il2CppReferenceArray<LocalDefinition> args, MethodInfo indexer, int argumentIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndexMethodByRefUpdater>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(obj));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indexer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref argumentIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexMethodByRefUpdater.NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_LocalDefinition_Il2CppReferenceArray_1_LocalDefinition_MethodInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00045BA8 File Offset: 0x00043DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022423, XrefRangeEnd = 1022434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update(InterpretedFrame frame, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexMethodByRefUpdater.NativeMethodInfoPtr_Update_Public_Virtual_Void_InterpretedFrame_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x00045BFC File Offset: 0x00043DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022434, XrefRangeEnd = 1022450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UndefineTemps(InstructionList instructions, LocalVariables locals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instructions);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locals);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexMethodByRefUpdater.NativeMethodInfoPtr_UndefineTemps_Public_Virtual_Void_InstructionList_LocalVariables_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x00005FC7 File Offset: 0x000041C7
		public IndexMethodByRefUpdater(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000D0B RID: 3339 RVA: 0x00045C50 File Offset: 0x00043E50
		// (set) Token: 0x06000D0C RID: 3340 RVA: 0x00005FD0 File Offset: 0x000041D0
		public unsafe MethodInfo _indexer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexMethodByRefUpdater.NativeFieldInfoPtr__indexer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexMethodByRefUpdater.NativeFieldInfoPtr__indexer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000D0D RID: 3341 RVA: 0x00045C80 File Offset: 0x00043E80
		// (set) Token: 0x06000D0E RID: 3342 RVA: 0x00005FEF File Offset: 0x000041EF
		public Nullable<LocalDefinition> _obj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexMethodByRefUpdater.NativeFieldInfoPtr__obj);
				return new Nullable<LocalDefinition>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<LocalDefinition>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexMethodByRefUpdater.NativeFieldInfoPtr__obj), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<LocalDefinition>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000D0F RID: 3343 RVA: 0x00045CB0 File Offset: 0x00043EB0
		// (set) Token: 0x06000D10 RID: 3344 RVA: 0x0000601D File Offset: 0x0000421D
		public unsafe Il2CppReferenceArray<LocalDefinition> _args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexMethodByRefUpdater.NativeFieldInfoPtr__args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LocalDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexMethodByRefUpdater.NativeFieldInfoPtr__args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000996 RID: 2454
		private static readonly IntPtr NativeFieldInfoPtr__indexer;

		// Token: 0x04000997 RID: 2455
		private static readonly IntPtr NativeFieldInfoPtr__obj;

		// Token: 0x04000998 RID: 2456
		private static readonly IntPtr NativeFieldInfoPtr__args;

		// Token: 0x04000999 RID: 2457
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_LocalDefinition_Il2CppReferenceArray_1_LocalDefinition_MethodInfo_Int32_0;

		// Token: 0x0400099A RID: 2458
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_InterpretedFrame_Object_0;

		// Token: 0x0400099B RID: 2459
		private static readonly IntPtr NativeMethodInfoPtr_UndefineTemps_Public_Virtual_Void_InstructionList_LocalVariables_0;
	}
}
