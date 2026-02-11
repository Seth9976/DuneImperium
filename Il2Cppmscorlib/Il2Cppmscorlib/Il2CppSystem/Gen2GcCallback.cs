using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.ConstrainedExecution;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppSystem
{
	// Token: 0x02000096 RID: 150
	public sealed class Gen2GcCallback : CriticalFinalizerObject
	{
		// Token: 0x06000A26 RID: 2598 RVA: 0x00053B10 File Offset: 0x00051D10
		// Note: this type is marked as 'beforefieldinit'.
		static Gen2GcCallback()
		{
			Il2CppClassPointerStore<Gen2GcCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Gen2GcCallback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Gen2GcCallback>.NativeClassPtr);
			Gen2GcCallback.NativeFieldInfoPtr__callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gen2GcCallback>.NativeClassPtr, "_callback");
			Gen2GcCallback.NativeFieldInfoPtr__weakTargetObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gen2GcCallback>.NativeClassPtr, "_weakTargetObj");
			Gen2GcCallback.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gen2GcCallback>.NativeClassPtr, 100665069);
			Gen2GcCallback.NativeMethodInfoPtr_Register_Public_Static_Void_Func_2_Object_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gen2GcCallback>.NativeClassPtr, 100665070);
			Gen2GcCallback.NativeMethodInfoPtr_Setup_Private_Void_Func_2_Object_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gen2GcCallback>.NativeClassPtr, 100665071);
			Gen2GcCallback.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gen2GcCallback>.NativeClassPtr, 100665072);
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x00053BB8 File Offset: 0x00051DB8
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Gen2GcCallback()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Gen2GcCallback>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gen2GcCallback.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x00053BF4 File Offset: 0x00051DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1304660, XrefRangeEnd = 1304666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Register(Func<Object, bool> callback, Object targetObj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetObj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gen2GcCallback.NativeMethodInfoPtr_Register_Public_Static_Void_Func_2_Object_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x00053C3C File Offset: 0x00051E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1304666, XrefRangeEnd = 1304668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Setup(Func<Object, bool> callback, Object targetObj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetObj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gen2GcCallback.NativeMethodInfoPtr_Setup_Private_Void_Func_2_Object_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x00053C90 File Offset: 0x00051E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1304668, XrefRangeEnd = 1304683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gen2GcCallback.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x000047E9 File Offset: 0x000029E9
		public Gen2GcCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x00053CC4 File Offset: 0x00051EC4
		// (set) Token: 0x06000A2D RID: 2605 RVA: 0x000047F2 File Offset: 0x000029F2
		public unsafe Func<Object, bool> _callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gen2GcCallback.NativeFieldInfoPtr__callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gen2GcCallback.NativeFieldInfoPtr__callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000A2E RID: 2606 RVA: 0x00053CF4 File Offset: 0x00051EF4
		// (set) Token: 0x06000A2F RID: 2607 RVA: 0x00004811 File Offset: 0x00002A11
		public unsafe GCHandle _weakTargetObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gen2GcCallback.NativeFieldInfoPtr__weakTargetObj);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gen2GcCallback.NativeFieldInfoPtr__weakTargetObj)) = value;
			}
		}

		// Token: 0x040007EE RID: 2030
		private static readonly IntPtr NativeFieldInfoPtr__callback;

		// Token: 0x040007EF RID: 2031
		private static readonly IntPtr NativeFieldInfoPtr__weakTargetObj;

		// Token: 0x040007F0 RID: 2032
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040007F1 RID: 2033
		private static readonly IntPtr NativeMethodInfoPtr_Register_Public_Static_Void_Func_2_Object_Boolean_Object_0;

		// Token: 0x040007F2 RID: 2034
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Private_Void_Func_2_Object_Boolean_Object_0;

		// Token: 0x040007F3 RID: 2035
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
	}
}
