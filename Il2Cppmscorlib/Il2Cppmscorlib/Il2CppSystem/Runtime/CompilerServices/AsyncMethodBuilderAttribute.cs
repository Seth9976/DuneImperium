using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003A8 RID: 936
	public sealed class AsyncMethodBuilderAttribute : Attribute
	{
		// Token: 0x060038B7 RID: 14519 RVA: 0x00113D18 File Offset: 0x00111F18
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncMethodBuilderAttribute()
		{
			Il2CppClassPointerStore<AsyncMethodBuilderAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "AsyncMethodBuilderAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncMethodBuilderAttribute>.NativeClassPtr);
			AsyncMethodBuilderAttribute.NativeFieldInfoPtr__BuilderType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderAttribute>.NativeClassPtr, "<BuilderType>k__BackingField");
			AsyncMethodBuilderAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderAttribute>.NativeClassPtr, 100671774);
		}

		// Token: 0x060038B8 RID: 14520 RVA: 0x00113D70 File Offset: 0x00111F70
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncMethodBuilderAttribute(Type builderType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncMethodBuilderAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builderType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060038B9 RID: 14521 RVA: 0x00014CFC File Offset: 0x00012EFC
		public AsyncMethodBuilderAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x060038BA RID: 14522 RVA: 0x00113DBC File Offset: 0x00111FBC
		// (set) Token: 0x060038BB RID: 14523 RVA: 0x00014D05 File Offset: 0x00012F05
		public unsafe Type _BuilderType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderAttribute.NativeFieldInfoPtr__BuilderType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderAttribute.NativeFieldInfoPtr__BuilderType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002E51 RID: 11857
		private static readonly IntPtr NativeFieldInfoPtr__BuilderType_k__BackingField;

		// Token: 0x04002E52 RID: 11858
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
	}
}
