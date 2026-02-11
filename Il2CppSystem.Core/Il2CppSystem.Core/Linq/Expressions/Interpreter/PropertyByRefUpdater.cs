using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000D3 RID: 211
	public sealed class PropertyByRefUpdater : ByRefUpdater
	{
		// Token: 0x06000CFD RID: 3325 RVA: 0x00045870 File Offset: 0x00043A70
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyByRefUpdater()
		{
			Il2CppClassPointerStore<PropertyByRefUpdater>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "PropertyByRefUpdater");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyByRefUpdater>.NativeClassPtr);
			PropertyByRefUpdater.NativeFieldInfoPtr__object = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyByRefUpdater>.NativeClassPtr, "_object");
			PropertyByRefUpdater.NativeFieldInfoPtr__property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyByRefUpdater>.NativeClassPtr, "_property");
			PropertyByRefUpdater.NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_LocalDefinition_PropertyInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyByRefUpdater>.NativeClassPtr, 100665654);
			PropertyByRefUpdater.NativeMethodInfoPtr_Update_Public_Virtual_Void_InterpretedFrame_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyByRefUpdater>.NativeClassPtr, 100665655);
			PropertyByRefUpdater.NativeMethodInfoPtr_UndefineTemps_Public_Virtual_Void_InstructionList_LocalVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyByRefUpdater>.NativeClassPtr, 100665656);
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x00045904 File Offset: 0x00043B04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1022399, RefRangeEnd = 1022401, XrefRangeStart = 1022399, XrefRangeEnd = 1022401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyByRefUpdater(Nullable<LocalDefinition> obj, PropertyInfo property, int argumentIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyByRefUpdater>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(obj));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref argumentIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyByRefUpdater.NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_LocalDefinition_PropertyInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x00045974 File Offset: 0x00043B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022411, XrefRangeEnd = 1022414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyByRefUpdater.NativeMethodInfoPtr_Update_Public_Virtual_Void_InterpretedFrame_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x000459C8 File Offset: 0x00043BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022414, XrefRangeEnd = 1022418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyByRefUpdater.NativeMethodInfoPtr_UndefineTemps_Public_Virtual_Void_InstructionList_LocalVariables_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x00005F71 File Offset: 0x00004171
		public PropertyByRefUpdater(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000D02 RID: 3330 RVA: 0x00045A1C File Offset: 0x00043C1C
		// (set) Token: 0x06000D03 RID: 3331 RVA: 0x00005F7A File Offset: 0x0000417A
		public Nullable<LocalDefinition> _object
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyByRefUpdater.NativeFieldInfoPtr__object);
				return new Nullable<LocalDefinition>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<LocalDefinition>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyByRefUpdater.NativeFieldInfoPtr__object), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<LocalDefinition>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000D04 RID: 3332 RVA: 0x00045A4C File Offset: 0x00043C4C
		// (set) Token: 0x06000D05 RID: 3333 RVA: 0x00005FA8 File Offset: 0x000041A8
		public unsafe PropertyInfo _property
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyByRefUpdater.NativeFieldInfoPtr__property);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyByRefUpdater.NativeFieldInfoPtr__property), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000991 RID: 2449
		private static readonly IntPtr NativeFieldInfoPtr__object;

		// Token: 0x04000992 RID: 2450
		private static readonly IntPtr NativeFieldInfoPtr__property;

		// Token: 0x04000993 RID: 2451
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_LocalDefinition_PropertyInfo_Int32_0;

		// Token: 0x04000994 RID: 2452
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_InterpretedFrame_Object_0;

		// Token: 0x04000995 RID: 2453
		private static readonly IntPtr NativeMethodInfoPtr_UndefineTemps_Public_Virtual_Void_InstructionList_LocalVariables_0;
	}
}
