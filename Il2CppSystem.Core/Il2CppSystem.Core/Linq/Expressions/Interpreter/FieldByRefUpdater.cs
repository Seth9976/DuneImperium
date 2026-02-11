using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000D2 RID: 210
	public sealed class FieldByRefUpdater : ByRefUpdater
	{
		// Token: 0x06000CF4 RID: 3316 RVA: 0x00045664 File Offset: 0x00043864
		// Note: this type is marked as 'beforefieldinit'.
		static FieldByRefUpdater()
		{
			Il2CppClassPointerStore<FieldByRefUpdater>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "FieldByRefUpdater");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FieldByRefUpdater>.NativeClassPtr);
			FieldByRefUpdater.NativeFieldInfoPtr__object = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldByRefUpdater>.NativeClassPtr, "_object");
			FieldByRefUpdater.NativeFieldInfoPtr__field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldByRefUpdater>.NativeClassPtr, "_field");
			FieldByRefUpdater.NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_LocalDefinition_FieldInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldByRefUpdater>.NativeClassPtr, 100665651);
			FieldByRefUpdater.NativeMethodInfoPtr_Update_Public_Virtual_Void_InterpretedFrame_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldByRefUpdater>.NativeClassPtr, 100665652);
			FieldByRefUpdater.NativeMethodInfoPtr_UndefineTemps_Public_Virtual_Void_InstructionList_LocalVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldByRefUpdater>.NativeClassPtr, 100665653);
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x000456F8 File Offset: 0x000438F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1022399, RefRangeEnd = 1022401, XrefRangeStart = 1022396, XrefRangeEnd = 1022399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FieldByRefUpdater(Nullable<LocalDefinition> obj, FieldInfo field, int argumentIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FieldByRefUpdater>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(obj));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(field);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref argumentIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldByRefUpdater.NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_LocalDefinition_FieldInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x00045768 File Offset: 0x00043968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022401, XrefRangeEnd = 1022407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldByRefUpdater.NativeMethodInfoPtr_Update_Public_Virtual_Void_InterpretedFrame_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x000457BC File Offset: 0x000439BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022407, XrefRangeEnd = 1022411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldByRefUpdater.NativeMethodInfoPtr_UndefineTemps_Public_Virtual_Void_InstructionList_LocalVariables_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x00005F1B File Offset: 0x0000411B
		public FieldByRefUpdater(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000CF9 RID: 3321 RVA: 0x00045810 File Offset: 0x00043A10
		// (set) Token: 0x06000CFA RID: 3322 RVA: 0x00005F24 File Offset: 0x00004124
		public Nullable<LocalDefinition> _object
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldByRefUpdater.NativeFieldInfoPtr__object);
				return new Nullable<LocalDefinition>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<LocalDefinition>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldByRefUpdater.NativeFieldInfoPtr__object), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<LocalDefinition>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000CFB RID: 3323 RVA: 0x00045840 File Offset: 0x00043A40
		// (set) Token: 0x06000CFC RID: 3324 RVA: 0x00005F52 File Offset: 0x00004152
		public unsafe FieldInfo _field
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldByRefUpdater.NativeFieldInfoPtr__field);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldByRefUpdater.NativeFieldInfoPtr__field), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400098C RID: 2444
		private static readonly IntPtr NativeFieldInfoPtr__object;

		// Token: 0x0400098D RID: 2445
		private static readonly IntPtr NativeFieldInfoPtr__field;

		// Token: 0x0400098E RID: 2446
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_LocalDefinition_FieldInfo_Int32_0;

		// Token: 0x0400098F RID: 2447
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_InterpretedFrame_Object_0;

		// Token: 0x04000990 RID: 2448
		private static readonly IntPtr NativeMethodInfoPtr_UndefineTemps_Public_Virtual_Void_InstructionList_LocalVariables_0;
	}
}
