package ca.ubc.cs.simpleram;

import java.util.Arrays;
import java.util.List;

import com.cburch.logisim.tools.AddTool;
import com.cburch.logisim.tools.Library;

public class Components extends Library
{
    /**
     * The list of all tools contained in this library.
     */
    private List<AddTool> tools;

    /**
     *  Constructs an instance of this library.
     */
    public Components()
    {
	tools = Arrays.asList(new AddTool[] {
		new AddTool(new SimpleRam()),
	});
    }

    /** Returns the name of the library that the user will see. */
    @Override
    public String getDisplayName()
    {
	return "CPSC 121";
    }

    /** Returns a list of all the tools available in this library. */
    @Override
    public List<AddTool> getTools()
    {
	return tools;
    }
}
