using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.Options
{
	// Token: 0x0200000D RID: 13
	public class ConfigureOptions<TOptions> : Object where TOptions : class
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00002F74 File Offset: 0x00001174
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigureOptions()
		{
			Il2CppClassPointerStore<ConfigureOptions<TOptions>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Microsoft.Extensions.Options.dll", "Microsoft.Extensions.Options", "ConfigureOptions`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOptions>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigureOptions<TOptions>>.NativeClassPtr);
			ConfigureOptions<TOptions>.NativeFieldInfoPtr__Action_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigureOptions<TOptions>>.NativeClassPtr, "<Action>k__BackingField");
			ConfigureOptions<TOptions>.NativeMethodInfoPtr__ctor_Public_Void_Action_1_TOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureOptions<TOptions>>.NativeClassPtr, 100663309);
			ConfigureOptions<TOptions>.NativeMethodInfoPtr_get_Action_Public_get_Action_1_TOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureOptions<TOptions>>.NativeClassPtr, 100663310);
			ConfigureOptions<TOptions>.NativeMethodInfoPtr_Configure_Public_Virtual_New_Void_TOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigureOptions<TOptions>>.NativeClassPtr, 100663311);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003030 File Offset: 0x00001230
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigureOptions(Action<TOptions> action)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigureOptions<TOptions>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureOptions<TOptions>.NativeMethodInfoPtr__ctor_Public_Void_Action_1_TOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000033 RID: 51 RVA: 0x0000307C File Offset: 0x0000127C
		public unsafe Action<TOptions> Action
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigureOptions<TOptions>.NativeMethodInfoPtr_get_Action_Public_get_Action_1_TOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<TOptions>>(intPtr3) : null;
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000030BC File Offset: 0x000012BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265670, XrefRangeEnd = 1265673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Configure(TOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TOptions).IsValueType)
				{
					TOptions toptions = options;
					intPtr = ((toptions is string) ? IL2CPP.ManagedStringToIl2Cpp(toptions as string) : IL2CPP.Il2CppObjectBaseToPtr(toptions as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref options;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigureOptions<TOptions>.NativeMethodInfoPtr_Configure_Public_Virtual_New_Void_TOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002200 File Offset: 0x00000400
		public ConfigureOptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00003140 File Offset: 0x00001340
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00002209 File Offset: 0x00000409
		public unsafe Action<TOptions> _Action_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureOptions<TOptions>.NativeFieldInfoPtr__Action_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TOptions>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigureOptions<TOptions>.NativeFieldInfoPtr__Action_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr__Action_k__BackingField;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_1_TOptions_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_get_Action_Public_get_Action_1_TOptions_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Virtual_New_Void_TOptions_0;
	}
}
