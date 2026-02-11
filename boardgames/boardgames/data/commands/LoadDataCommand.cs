using System;
using dwd.core;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace boardgames.data.commands
{
	// Token: 0x02000148 RID: 328
	public class LoadDataCommand : Command
	{
		// Token: 0x060010C5 RID: 4293 RVA: 0x00044960 File Offset: 0x00042B60
		// Note: this type is marked as 'beforefieldinit'.
		static LoadDataCommand()
		{
			Il2CppClassPointerStore<LoadDataCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.data.commands", "LoadDataCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadDataCommand>.NativeClassPtr);
			LoadDataCommand.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadDataCommand>.NativeClassPtr, "path");
			LoadDataCommand.NativeFieldInfoPtr_loadType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadDataCommand>.NativeClassPtr, "loadType");
			LoadDataCommand.NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadDataCommand>.NativeClassPtr, "status");
			LoadDataCommand.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadDataCommand>.NativeClassPtr, "result");
			LoadDataCommand.NativeMethodInfoPtr__ctor_Protected_Void_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadDataCommand>.NativeClassPtr, 100665745);
			LoadDataCommand.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadDataCommand>.NativeClassPtr, 100665746);
			LoadDataCommand.NativeMethodInfoPtr_Result_Public_Virtual_Final_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadDataCommand>.NativeClassPtr, 100665747);
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x00044A1C File Offset: 0x00042C1C
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 495165, RefRangeEnd = 495182, XrefRangeStart = 495165, XrefRangeEnd = 495182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadDataCommand(string path, Type loadType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadDataCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loadType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadDataCommand.NativeMethodInfoPtr__ctor_Protected_Void_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x00044A7C File Offset: 0x00042C7C
		[CallerCount(0)]
		public unsafe virtual ErrorInfo Status()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadDataCommand.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ErrorInfo(intPtr);
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x00044AB4 File Offset: 0x00042CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999450, XrefRangeEnd = 999456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual T Result<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadDataCommand.MethodInfoStoreGeneric_Result_Public_Virtual_Final_New_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x00009C8A File Offset: 0x00007E8A
		public LoadDataCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x060010CA RID: 4298 RVA: 0x00044AF0 File Offset: 0x00042CF0
		// (set) Token: 0x060010CB RID: 4299 RVA: 0x00009C93 File Offset: 0x00007E93
		public unsafe string path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadDataCommand.NativeFieldInfoPtr_path);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadDataCommand.NativeFieldInfoPtr_path), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x060010CC RID: 4300 RVA: 0x00044B18 File Offset: 0x00042D18
		// (set) Token: 0x060010CD RID: 4301 RVA: 0x00009CB2 File Offset: 0x00007EB2
		public unsafe Type loadType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadDataCommand.NativeFieldInfoPtr_loadType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadDataCommand.NativeFieldInfoPtr_loadType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x060010CE RID: 4302 RVA: 0x00044B48 File Offset: 0x00042D48
		// (set) Token: 0x060010CF RID: 4303 RVA: 0x00009CD1 File Offset: 0x00007ED1
		public ErrorInfo status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadDataCommand.NativeFieldInfoPtr_status);
				return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadDataCommand.NativeFieldInfoPtr_status), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x060010D0 RID: 4304 RVA: 0x00044B78 File Offset: 0x00042D78
		// (set) Token: 0x060010D1 RID: 4305 RVA: 0x00009CFF File Offset: 0x00007EFF
		public unsafe Object result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadDataCommand.NativeFieldInfoPtr_result);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadDataCommand.NativeFieldInfoPtr_result), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A37 RID: 2615
		private static readonly IntPtr NativeFieldInfoPtr_path;

		// Token: 0x04000A38 RID: 2616
		private static readonly IntPtr NativeFieldInfoPtr_loadType;

		// Token: 0x04000A39 RID: 2617
		private static readonly IntPtr NativeFieldInfoPtr_status;

		// Token: 0x04000A3A RID: 2618
		private static readonly IntPtr NativeFieldInfoPtr_result;

		// Token: 0x04000A3B RID: 2619
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_Type_0;

		// Token: 0x04000A3C RID: 2620
		private static readonly IntPtr NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0;

		// Token: 0x04000A3D RID: 2621
		private static readonly IntPtr NativeMethodInfoPtr_Result_Public_Virtual_Final_New_T_0;

		// Token: 0x02000273 RID: 627
		private sealed class MethodInfoStoreGeneric_Result_Public_Virtual_Final_New_T_0<T>
		{
			// Token: 0x04001192 RID: 4498
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LoadDataCommand.NativeMethodInfoPtr_Result_Public_Virtual_Final_New_T_0, Il2CppClassPointerStore<LoadDataCommand>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
