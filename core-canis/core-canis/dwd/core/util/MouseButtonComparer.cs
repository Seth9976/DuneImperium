using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.util
{
	// Token: 0x02000099 RID: 153
	public sealed class MouseButtonComparer : EqualityComparer<MouseButton>
	{
		// Token: 0x06000A7D RID: 2685 RVA: 0x0003B61C File Offset: 0x0003981C
		// Note: this type is marked as 'beforefieldinit'.
		static MouseButtonComparer()
		{
			Il2CppClassPointerStore<MouseButtonComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.util", "MouseButtonComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseButtonComparer>.NativeClassPtr);
			MouseButtonComparer.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseButtonComparer>.NativeClassPtr, "Default");
			MouseButtonComparer.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseButtonComparer>.NativeClassPtr, 100664753);
			MouseButtonComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_MouseButton_MouseButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseButtonComparer>.NativeClassPtr, 100664754);
			MouseButtonComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_MouseButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseButtonComparer>.NativeClassPtr, 100664755);
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x0003B69C File Offset: 0x0003989C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 862855, XrefRangeEnd = 862858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MouseButtonComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MouseButtonComparer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseButtonComparer.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x0003B6D8 File Offset: 0x000398D8
		[CallerCount(0)]
		public unsafe override bool Equals(MouseButton x, MouseButton y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseButtonComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_MouseButton_MouseButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x0003B730 File Offset: 0x00039930
		[CallerCount(0)]
		public unsafe override int GetHashCode(MouseButton obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MouseButtonComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_MouseButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x00005BE6 File Offset: 0x00003DE6
		public MouseButtonComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000A82 RID: 2690 RVA: 0x0003B77C File Offset: 0x0003997C
		// (set) Token: 0x06000A83 RID: 2691 RVA: 0x00005BEF File Offset: 0x00003DEF
		public new unsafe static MouseButtonComparer Default
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MouseButtonComparer.NativeFieldInfoPtr_Default, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MouseButtonComparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MouseButtonComparer.NativeFieldInfoPtr_Default, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007AD RID: 1965
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x040007AE RID: 1966
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040007AF RID: 1967
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_MouseButton_MouseButton_0;

		// Token: 0x040007B0 RID: 1968
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_MouseButton_0;
	}
}
